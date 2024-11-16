namespace CSCI363Project
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panel1 = new Panel();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sunroofBox = new PictureBox();
            engineBox = new PictureBox();
            upWindowBox = new PictureBox();
            alarmBox = new PictureBox();
            downWindowBox = new PictureBox();
            doorBox = new PictureBox();
            mainBox = new Button();
            carInfoBox = new Button();
            controlsBox = new Button();
            settingsBox = new Button();
            dateTimePicker1 = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sunroofBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engineBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upWindowBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alarmBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downWindowBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 2);
            panel1.TabIndex = 24;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(405, 1);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 21);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 23;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(334, 1);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(28, 21);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 22;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(371, 1);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(28, 21);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 21;
            pictureBox11.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(155, 509);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 35;
            label5.Text = "Alarm On/Off";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(281, 364);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 34;
            label4.Text = "Open/Close Sunroof";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(51, 364);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 33;
            label3.Text = "Windows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(282, 204);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 32;
            label2.Text = "Lock/Unlock Doors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 204);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 31;
            label1.Text = "Start/Stop Engine";
            // 
            // sunroofBox
            // 
            sunroofBox.BorderStyle = BorderStyle.Fixed3D;
            sunroofBox.Image = (Image)resources.GetObject("sunroofBox.Image");
            sunroofBox.Location = new Point(282, 256);
            sunroofBox.Name = "sunroofBox";
            sunroofBox.Size = new Size(147, 105);
            sunroofBox.SizeMode = PictureBoxSizeMode.StretchImage;
            sunroofBox.TabIndex = 30;
            sunroofBox.TabStop = false;
            sunroofBox.Click += sunroofBox_Click;
            // 
            // engineBox
            // 
            engineBox.BorderStyle = BorderStyle.Fixed3D;
            engineBox.Image = (Image)resources.GetObject("engineBox.Image");
            engineBox.Location = new Point(27, 47);
            engineBox.Name = "engineBox";
            engineBox.Size = new Size(138, 143);
            engineBox.SizeMode = PictureBoxSizeMode.Zoom;
            engineBox.TabIndex = 29;
            engineBox.TabStop = false;
            engineBox.Click += engineBox_Click;
            // 
            // upWindowBox
            // 
            upWindowBox.BorderStyle = BorderStyle.Fixed3D;
            upWindowBox.Image = (Image)resources.GetObject("upWindowBox.Image");
            upWindowBox.Location = new Point(27, 270);
            upWindowBox.Name = "upWindowBox";
            upWindowBox.Size = new Size(57, 91);
            upWindowBox.SizeMode = PictureBoxSizeMode.Zoom;
            upWindowBox.TabIndex = 28;
            upWindowBox.TabStop = false;
            upWindowBox.Click += upWindowBox_Click;
            // 
            // alarmBox
            // 
            alarmBox.BorderStyle = BorderStyle.Fixed3D;
            alarmBox.Image = (Image)resources.GetObject("alarmBox.Image");
            alarmBox.Location = new Point(145, 393);
            alarmBox.Name = "alarmBox";
            alarmBox.Size = new Size(133, 113);
            alarmBox.SizeMode = PictureBoxSizeMode.Zoom;
            alarmBox.TabIndex = 27;
            alarmBox.TabStop = false;
            alarmBox.Click += alarmBox_Click;
            // 
            // downWindowBox
            // 
            downWindowBox.BorderStyle = BorderStyle.Fixed3D;
            downWindowBox.Image = (Image)resources.GetObject("downWindowBox.Image");
            downWindowBox.Location = new Point(90, 270);
            downWindowBox.Name = "downWindowBox";
            downWindowBox.Size = new Size(55, 91);
            downWindowBox.SizeMode = PictureBoxSizeMode.StretchImage;
            downWindowBox.TabIndex = 26;
            downWindowBox.TabStop = false;
            downWindowBox.Click += downWindowBox_Click;
            // 
            // doorBox
            // 
            doorBox.BorderStyle = BorderStyle.Fixed3D;
            doorBox.Image = (Image)resources.GetObject("doorBox.Image");
            doorBox.Location = new Point(282, 47);
            doorBox.Name = "doorBox";
            doorBox.Size = new Size(147, 143);
            doorBox.SizeMode = PictureBoxSizeMode.Zoom;
            doorBox.TabIndex = 25;
            doorBox.TabStop = false;
            doorBox.Click += doorBox_Click;
            // 
            // mainBox
            // 
            mainBox.BackColor = Color.Transparent;
            mainBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainBox.Location = new Point(12, 565);
            mainBox.Name = "mainBox";
            mainBox.Size = new Size(100, 54);
            mainBox.TabIndex = 36;
            mainBox.Text = "Main";
            mainBox.UseVisualStyleBackColor = false;
            // 
            // carInfoBox
            // 
            carInfoBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carInfoBox.Location = new Point(117, 565);
            carInfoBox.Name = "carInfoBox";
            carInfoBox.Size = new Size(100, 54);
            carInfoBox.TabIndex = 37;
            carInfoBox.Text = "Car Info";
            carInfoBox.UseVisualStyleBackColor = true;
            carInfoBox.Click += carInfoBox_Click;
            // 
            // controlsBox
            // 
            controlsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlsBox.Location = new Point(223, 565);
            controlsBox.Name = "controlsBox";
            controlsBox.Size = new Size(100, 54);
            controlsBox.TabIndex = 38;
            controlsBox.Text = "Controls";
            controlsBox.UseVisualStyleBackColor = true;
            controlsBox.Click += controlsBox_Click;
            // 
            // settingsBox
            // 
            settingsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBox.Location = new Point(329, 565);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new Size(100, 54);
            settingsBox.TabIndex = 39;
            settingsBox.Text = "Settings";
            settingsBox.UseVisualStyleBackColor = true;
            settingsBox.Click += settingsBox_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F);
            dateTimePicker1.Font = new Font("Segoe UI", 7F);
            dateTimePicker1.Location = new Point(0, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 20);
            dateTimePicker1.TabIndex = 40;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 7);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 41;
            label6.Text = "label6";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(441, 631);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(settingsBox);
            Controls.Add(controlsBox);
            Controls.Add(carInfoBox);
            Controls.Add(mainBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sunroofBox);
            Controls.Add(engineBox);
            Controls.Add(upWindowBox);
            Controls.Add(alarmBox);
            Controls.Add(downWindowBox);
            Controls.Add(doorBox);
            Controls.Add(panel1);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Name = "MainPage";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)sunroofBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)engineBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)upWindowBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)alarmBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)downWindowBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox sunroofBox;
        private PictureBox engineBox;
        private PictureBox upWindowBox;
        private PictureBox alarmBox;
        private PictureBox downWindowBox;
        private PictureBox doorBox;
        private Button mainBox;
        private Button carInfoBox;
        private Button controlsBox;
        private Button settingsBox;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
    }
}
