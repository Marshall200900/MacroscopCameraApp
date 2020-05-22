using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskCamerasMacroscop
{
    public partial class mainForm : Form
    {
        const string LABEL_NAME = "Camera name: ";
        const string DEFAULT_URL = @"http://demo.macroscop.com:8080/mobile?login=root";
        string curUrl = "http://demo.macroscop.com:8080/mobile?login=root&channelid=2016897c-8be5-4a80-b1a3-7f79a9ec729c&resolutionX=640&resolutionY=360&fps=20";
        XDocument xml;
        CancellationTokenSource cts = new CancellationTokenSource();
        Button activeButton;

        public mainForm()
        {

            InitializeComponent();
            LoadXml(@"http://demo.macroscop.com:8080/configex?login=root");

            Task.Run(() => Parse());
            nameLabel.Text =  LABEL_NAME + "Entrance";
            activeButton = corridorBtn;
            SetGreenColor(corridorBtn);
        }


        async Task Parse()
        {
            VideoDecoder decoder = new VideoDecoder();

            await decoder.StartAsync(image => {
                pictureCam.Image = image;
                
            }, curUrl, cts.Token);


        }

        private void SetGreenColor(Button btn)
        {
            activeButton.BackColor = Color.White;
            btn.BackColor = Color.FromArgb(128, 255, 128);
            activeButton = btn;
        }

        private void LoadXml(string url)
        {
            try
            {
                xml = XDocument.Load(url);
            }
            catch (WebException)
            {
                MessageBox.Show("An error occured while connecting to demo.macroscop.com\n" +
                    "Please check the internet connection");
                Environment.Exit(1);

            }
        }

        private void StartStreaming(string camera)
        {
            cts.Cancel();
            cts = new CancellationTokenSource();
            ChangeUrl(camera);
            nameLabel.Text = LABEL_NAME + camera;
            Task.Run(() => Parse());
        }

        private void ChangeUrl(string cameraName)
        {
            var channels = from xe in xml.Element("Configuration").Elements("Channels")
                           .Elements("ChannelInfo")
                           where xe.Attribute("Name").Value == cameraName
                           select xe;

            var query = HttpUtility.ParseQueryString("&");
            query["channelid"] = channels.First().Attribute("Id").Value;
            query["fps"] = "10";
            curUrl = DEFAULT_URL + query.ToString();
            Console.WriteLine(curUrl);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            StartStreaming("Corridor");
            nameLabel.Text = LABEL_NAME + "Corridor";

            SetGreenColor(corridorBtn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartStreaming("Road");
            nameLabel.Text = LABEL_NAME + "Road";
            SetGreenColor(roadBtn);



        }

        private void parkingBtn_Click(object sender, EventArgs e)
        {
            StartStreaming("Parking");
            nameLabel.Text = LABEL_NAME + "Parking";
            SetGreenColor(parkingBtn);

        }
        
        private void entranceBtn_Click(object sender, EventArgs e)
        {
            StartStreaming("Entrance");
            nameLabel.Text = LABEL_NAME + "Entrance";
            SetGreenColor(entranceBtn);

        }

        private void parkingOfficeBtn_Click(object sender, EventArgs e)
        {
            StartStreaming("Parking in the office center");
            nameLabel.Text = LABEL_NAME + "Parking in the office center";
            SetGreenColor(parkingOfficeBtn);

        }
    }
}
