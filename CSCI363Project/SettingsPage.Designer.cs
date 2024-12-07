namespace CSCI363Project
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            updateAppBox = new PictureBox();
            nightTimeBox = new PictureBox();
            dayTimeBox = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            checkedListBox1 = new CheckedListBox();
            settingsBox = new Button();
            controlsBox = new Button();
            carInfoBox = new Button();
            mainBox = new Button();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)updateAppBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nightTimeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayTimeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 2);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 28;
            label1.Text = "Update Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 293);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 29;
            label2.Text = "Application Modes";
            // 
            // panel2
            // 
            panel2.Location = new Point(-1, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 2);
            panel2.TabIndex = 25;
            // 
            // updateAppBox
            // 
            updateAppBox.BorderStyle = BorderStyle.Fixed3D;
            updateAppBox.Image = (Image)resources.GetObject("updateAppBox.Image");
            updateAppBox.Location = new Point(98, 87);
            updateAppBox.Name = "updateAppBox";
            updateAppBox.Size = new Size(211, 151);
            updateAppBox.SizeMode = PictureBoxSizeMode.StretchImage;
            updateAppBox.TabIndex = 30;
            updateAppBox.TabStop = false;
            updateAppBox.Click += updateAppBox_Click;
            // 
            // nightTimeBox
            // 
            nightTimeBox.Image = (Image)resources.GetObject("nightTimeBox.Image");
            nightTimeBox.Location = new Point(333, 325);
            nightTimeBox.Name = "nightTimeBox";
            nightTimeBox.Size = new Size(42, 37);
            nightTimeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nightTimeBox.TabIndex = 32;
            nightTimeBox.TabStop = false;
            nightTimeBox.Click += nightTimeBox_Click;
            // 
            // dayTimeBox
            // 
            dayTimeBox.Image = (Image)resources.GetObject("dayTimeBox.Image");
            dayTimeBox.Location = new Point(141, 329);
            dayTimeBox.Name = "dayTimeBox";
            dayTimeBox.Size = new Size(50, 33);
            dayTimeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dayTimeBox.TabIndex = 33;
            dayTimeBox.TabStop = false;
            dayTimeBox.Click += dayTimeBox_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(-1, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 2);
            panel3.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 378);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 34;
            label3.Text = "Enable/Disable Features:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(31, 329);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 42;
            label11.Text = "Daytime:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(240, 329);
            label12.Name = "label12";
            label12.Size = new Size(87, 21);
            label12.TabIndex = 43;
            label12.Text = "Night time:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.White;
            checkedListBox1.Font = new Font("Segoe UI", 11F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Start/Stop Engine", "Lock/Unlock Doors", "Windows", "Alarm", "GPS", "Add Driver", "Add Vehicle" });
            checkedListBox1.Location = new Point(12, 410);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(420, 158);
            checkedListBox1.TabIndex = 44;
            // 
            // settingsBox
            // 
            settingsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBox.Location = new Point(332, 588);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new Size(100, 54);
            settingsBox.TabIndex = 56;
            settingsBox.Text = "Settings";
            settingsBox.UseVisualStyleBackColor = true;
            // 
            // controlsBox
            // 
            controlsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlsBox.Location = new Point(225, 588);
            controlsBox.Name = "controlsBox";
            controlsBox.Size = new Size(100, 54);
            controlsBox.TabIndex = 55;
            controlsBox.Text = "Controls";
            controlsBox.UseVisualStyleBackColor = true;
            controlsBox.Click += controlsBox_Click;
            // 
            // carInfoBox
            // 
            carInfoBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carInfoBox.Location = new Point(119, 588);
            carInfoBox.Name = "carInfoBox";
            carInfoBox.Size = new Size(100, 54);
            carInfoBox.TabIndex = 54;
            carInfoBox.Text = "Car Info";
            carInfoBox.UseVisualStyleBackColor = true;
            carInfoBox.Click += carInfoBox_Click;
            // 
            // mainBox
            // 
            mainBox.BackColor = Color.Transparent;
            mainBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainBox.Location = new Point(14, 588);
            mainBox.Name = "mainBox";
            mainBox.Size = new Size(100, 54);
            mainBox.TabIndex = 53;
            mainBox.Text = "Main";
            mainBox.UseVisualStyleBackColor = false;
            mainBox.Click += mainBox_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 7F);
            dateTimePicker1.Location = new Point(-1, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 20);
            dateTimePicker1.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(412, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(341, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(378, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 4);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 61;
            label4.Text = "label4";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(443, 654);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(settingsBox);
            Controls.Add(controlsBox);
            Controls.Add(carInfoBox);
            Controls.Add(mainBox);
            Controls.Add(checkedListBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(dayTimeBox);
            Controls.Add(nightTimeBox);
            Controls.Add(updateAppBox);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "SettingsPage";
            Text = "SettingsPage";
            ((System.ComponentModel.ISupportInitialize)updateAppBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nightTimeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayTimeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox updateAppBox;
        private PictureBox nightTimeBox;
        private PictureBox dayTimeBox;
        private Panel panel3;
        private Label label3;
        private Label label11;
        private Label label12;
        private CheckedListBox checkedListBox1;
        private Button settingsBox;
        private Button controlsBox;
        private Button carInfoBox;
        private Button mainBox;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}