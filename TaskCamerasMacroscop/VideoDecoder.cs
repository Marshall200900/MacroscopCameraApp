using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskCamerasMacroscop
{
    /// <summary>
    /// Simple mjpeg decoder
    /// </summary>
    public class VideoDecoder
    {
        //Each marker in JPEG file starts with 0xFF byte followed by marker flag. For instatnce, start of image marker is 0xFF0xD8.

        const byte picMarker = 0xFF; // the first byte of marker
        const byte picStart = 0xD8; // flag that represents the start of the image 
        const byte picEnd = 0xD9; // flag that represents the end of the image
        
        private readonly byte[] StreamBuffer = new byte[1024]; // buffer to read from stream
        private readonly byte[] FrameBuffer = new byte[1024 * 1024]; //array of bytes of the frame

        private int FrameIdx = 0; 
        private int StreamLength;
        private Action<Image> Action;
        private int CurIndex = 0;
        private byte CurrentByte = 0x00;
        private byte PreviousByte = 0x00; 
        private bool IsInPicture = false;

        /// <summary>
        /// Start http streaming
        /// </summary>
        /// <param name="action">delegate to run each time the frame is found</param>
        /// <param name="url">URL of the http stream</param>
        /// <param name="token">cancellation token is needed to stop streaming</param>
        /// <returns></returns>
        public async Task StartAsync(Action<Image> action, string url, CancellationToken? token = null)
        {
            Action = action;
            
            CancellationToken tkn = token ?? CancellationToken.None; // is needed to cancel the streaming
            
            using(var client = new HttpClient())
            {
                using(var stream = await client.GetStreamAsync(url)) //send url request and get data stream
                {
                    while (true)
                    {
                        StreamLength = await stream.ReadAsync(StreamBuffer, 0, 1024, tkn); // read 1024 bytes or until the end of file

                        CurIndex = 0; // index of byte in the StreamBuffer
                        while (CurIndex < StreamLength)
                        {
                            if (IsInPicture)
                            {
                                MakePicture();
                            }
                            else
                            {
                                SearchPicture();
                            }
                        }
                    };


                }
            }
        }
        private void SearchPicture()
        {
            do
            {
                PreviousByte = CurrentByte;
                CurrentByte = StreamBuffer[CurIndex++];

                if (PreviousByte == picMarker && CurrentByte == picStart)
                {
                    FrameIdx = 2;
                    FrameBuffer[0] = picMarker;
                    FrameBuffer[1] = picStart;
                    IsInPicture = true;
                    return;
                }
            } while (CurIndex < StreamLength);
        }

        private void MakePicture()
        {
            do
            {
                PreviousByte = CurrentByte;
                CurrentByte = StreamBuffer[CurIndex++];
                FrameBuffer[FrameIdx++] = CurrentByte;

                if (PreviousByte == picMarker && CurrentByte == picEnd)
                {
                    Image img = null;
                    //creating stream from buffer
                    using (var s = new MemoryStream(FrameBuffer, 0, FrameIdx))
                    {
                        try
                        {

                            //making a pic from stream

                            //stop animation loading
                            img = Image.FromStream(s);
                        }
                        catch
                        {
                            Console.WriteLine("Error while decoding a frame");
                        }
                    }


                    Task.Run(() => Action(img));
                    IsInPicture = false;
                    return;
                }
            } while (CurIndex < StreamLength);
        }

    }
}
