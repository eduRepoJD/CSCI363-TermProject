namespace CSCI363Project
{
    partial class CarInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfo));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            updateGPSBox = new PictureBox();
            label5 = new Label();
            settingsBox = new Button();
            controlsBox = new Button();
            carInfoBox = new Button();
            mainBox = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            timeZoneComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateGPSBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 2);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 2);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Location = new Point(1, 484);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 2);
            panel3.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.Location = new Point(1, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(444, 2);
            panel5.TabIndex = 25;
            // 
            // panel6
            // 
            panel6.Location = new Point(1, 165);
            panel6.Name = "panel6";
            panel6.Size = new Size(444, 2);
            panel6.TabIndex = 25;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(171, 27);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(5, 140);
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 27;
            label1.Text = "GPS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 28;
            label2.Text = "Driver Log:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 379);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 29;
            label3.Text = "Car Temperatures";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 489);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 30;
            label4.Text = "Battery Strength";
            // 
            // updateGPSBox
            // 
            updateGPSBox.BackColor = SystemColors.Control;
            updateGPSBox.BorderStyle = BorderStyle.Fixed3D;
            updateGPSBox.Image = (Image)resources.GetObject("updateGPSBox.Image");
            updateGPSBox.Location = new Point(28, 70);
            updateGPSBox.Name = "updateGPSBox";
            updateGPSBox.Size = new Size(116, 61);
            updateGPSBox.SizeMode = PictureBoxSizeMode.StretchImage;
            updateGPSBox.TabIndex = 31;
            updateGPSBox.TabStop = false;
            updateGPSBox.Click += updateGPSBox_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(35, 134);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 32;
            label5.Text = "Update GPS";
            // 
            // settingsBox
            // 
            settingsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBox.Location = new Point(330, 584);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new Size(100, 54);
            settingsBox.TabIndex = 51;
            settingsBox.Text = "Settings";
            settingsBox.UseVisualStyleBackColor = true;
            settingsBox.Click += settingsBox_Click;
            // 
            // controlsBox
            // 
            controlsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlsBox.Location = new Point(224, 584);
            controlsBox.Name = "controlsBox";
            controlsBox.Size = new Size(100, 54);
            controlsBox.TabIndex = 50;
            controlsBox.Text = "Controls";
            controlsBox.UseVisualStyleBackColor = true;
            controlsBox.Click += controlsBox_Click;
            // 
            // carInfoBox
            // 
            carInfoBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carInfoBox.Location = new Point(118, 584);
            carInfoBox.Name = "carInfoBox";
            carInfoBox.Size = new Size(100, 54);
            carInfoBox.TabIndex = 49;
            carInfoBox.Text = "Car Info";
            carInfoBox.UseVisualStyleBackColor = true;
            // 
            // mainBox
            // 
            mainBox.BackColor = Color.Transparent;
            mainBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainBox.Location = new Point(13, 584);
            mainBox.Name = "mainBox";
            mainBox.Size = new Size(100, 54);
            mainBox.TabIndex = 48;
            mainBox.Text = "Main";
            mainBox.UseVisualStyleBackColor = false;
            mainBox.Click += mainBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(28, 415);
            label6.Name = "label6";
            label6.Size = new Size(154, 21);
            label6.TabIndex = 53;
            label6.Text = "Internal Temperature";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(28, 445);
            label7.Name = "label7";
            label7.Size = new Size(156, 21);
            label7.TabIndex = 54;
            label7.Text = "External Temperature";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(330, 397);
            label8.Name = "label8";
            label8.Size = new Size(57, 37);
            label8.TabIndex = 55;
            label8.Text = "70°";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(330, 434);
            label9.Name = "label9";
            label9.Size = new Size(57, 37);
            label9.TabIndex = 56;
            label9.Text = "82°";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(308, 520);
            label10.Name = "label10";
            label10.Size = new Size(69, 37);
            label10.TabIndex = 57;
            label10.Text = "87%";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 7F);
            dateTimePicker1.Location = new Point(1, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 20);
            dateTimePicker1.TabIndex = 58;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(414, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(343, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(380, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 59;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(159, 7);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 62;
            label11.Text = "label11";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(17, 224);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(412, 144);
            textBox1.TabIndex = 63;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // timeZoneComboBox
            // 
            timeZoneComboBox.FormattingEnabled = true;
            timeZoneComboBox.Location = new Point(247, 3);
            timeZoneComboBox.Name = "timeZoneComboBox";
            timeZoneComboBox.Size = new Size(90, 23);
            timeZoneComboBox.TabIndex = 64;
            timeZoneComboBox.SelectedIndexChanged += timeZoneComboBox_SelectedIndexChanged;
            // 
            // CarInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(441, 650);
            Controls.Add(timeZoneComboBox);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(settingsBox);
            Controls.Add(controlsBox);
            Controls.Add(carInfoBox);
            Controls.Add(mainBox);
            Controls.Add(label5);
            Controls.Add(updateGPSBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "CarInfo";
            Text = "CarInfo";
            Load += CarInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateGPSBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox updateGPSBox;
        private Label label5;
        private Button settingsBox;
        private Button controlsBox;
        private Button carInfoBox;
        private Button mainBox;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label11;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private ComboBox timeZoneComboBox;
    }
}