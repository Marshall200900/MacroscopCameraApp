namespace TaskCamerasMacroscop
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureCam = new System.Windows.Forms.PictureBox();
            this.corridorBtn = new System.Windows.Forms.Button();
            this.parkingBtn = new System.Windows.Forms.Button();
            this.roadBtn = new System.Windows.Forms.Button();
            this.entranceBtn = new System.Windows.Forms.Button();
            this.parkingOfficeBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCam)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCam
            // 
            this.pictureCam.BackColor = System.Drawing.Color.White;
            this.pictureCam.Location = new System.Drawing.Point(4, 30);
            this.pictureCam.Name = "pictureCam";
            this.pictureCam.Size = new System.Drawing.Size(636, 331);
            this.pictureCam.TabIndex = 0;
            this.pictureCam.TabStop = false;
            // 
            // corridorBtn
            // 
            this.corridorBtn.BackColor = System.Drawing.Color.White;
            this.corridorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.corridorBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corridorBtn.Location = new System.Drawing.Point(646, 75);
            this.corridorBtn.Name = "corridorBtn";
            this.corridorBtn.Size = new System.Drawing.Size(67, 67);
            this.corridorBtn.TabIndex = 2;
            this.corridorBtn.Text = "Corridor";
            this.corridorBtn.UseVisualStyleBackColor = false;
            this.corridorBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // parkingBtn
            // 
            this.parkingBtn.BackColor = System.Drawing.Color.White;
            this.parkingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingBtn.Location = new System.Drawing.Point(646, 2);
            this.parkingBtn.Name = "parkingBtn";
            this.parkingBtn.Size = new System.Drawing.Size(67, 67);
            this.parkingBtn.TabIndex = 3;
            this.parkingBtn.Text = "Parking";
            this.parkingBtn.UseVisualStyleBackColor = false;
            this.parkingBtn.Click += new System.EventHandler(this.parkingBtn_Click);
            // 
            // roadBtn
            // 
            this.roadBtn.BackColor = System.Drawing.Color.White;
            this.roadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roadBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roadBtn.Location = new System.Drawing.Point(646, 148);
            this.roadBtn.Name = "roadBtn";
            this.roadBtn.Size = new System.Drawing.Size(67, 67);
            this.roadBtn.TabIndex = 4;
            this.roadBtn.Text = "Road";
            this.roadBtn.UseVisualStyleBackColor = false;
            this.roadBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // entranceBtn
            // 
            this.entranceBtn.BackColor = System.Drawing.Color.White;
            this.entranceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entranceBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entranceBtn.Location = new System.Drawing.Point(646, 221);
            this.entranceBtn.Name = "entranceBtn";
            this.entranceBtn.Size = new System.Drawing.Size(67, 67);
            this.entranceBtn.TabIndex = 5;
            this.entranceBtn.Text = "Entrance";
            this.entranceBtn.UseVisualStyleBackColor = false;
            this.entranceBtn.Click += new System.EventHandler(this.entranceBtn_Click);
            // 
            // parkingOfficeBtn
            // 
            this.parkingOfficeBtn.BackColor = System.Drawing.Color.White;
            this.parkingOfficeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingOfficeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingOfficeBtn.Location = new System.Drawing.Point(646, 294);
            this.parkingOfficeBtn.Name = "parkingOfficeBtn";
            this.parkingOfficeBtn.Size = new System.Drawing.Size(67, 67);
            this.parkingOfficeBtn.TabIndex = 6;
            this.parkingOfficeBtn.Text = "Parking in the office";
            this.parkingOfficeBtn.UseVisualStyleBackColor = false;
            this.parkingOfficeBtn.Click += new System.EventHandler(this.parkingOfficeBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(-1, 2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(152, 25);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Camera name: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 363);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.parkingOfficeBtn);
            this.Controls.Add(this.entranceBtn);
            this.Controls.Add(this.roadBtn);
            this.Controls.Add(this.parkingBtn);
            this.Controls.Add(this.corridorBtn);
            this.Controls.Add(this.pictureCam);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Macroscop Cameras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCam;
        private System.Windows.Forms.Button corridorBtn;
        private System.Windows.Forms.Button parkingBtn;
        private System.Windows.Forms.Button roadBtn;
        private System.Windows.Forms.Button entranceBtn;
        private System.Windows.Forms.Button parkingOfficeBtn;
        private System.Windows.Forms.Label nameLabel;
    }
}

