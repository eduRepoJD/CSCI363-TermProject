namespace CSCI363Project
{
    partial class Controls
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            flowLayoutDrivers = new FlowLayoutPanel();
            flowLayoutVehicles = new FlowLayoutPanel();
            btnMain = new Button();
            btnControls = new Button();
            btnCarInfo = new Button();
            btnSettings = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            timeZoneComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutDrivers
            // 
            flowLayoutDrivers.AutoScroll = true;
            flowLayoutDrivers.Location = new Point(12, 125);
            flowLayoutDrivers.Name = "flowLayoutDrivers";
            flowLayoutDrivers.Size = new Size(400, 150);
            flowLayoutDrivers.TabIndex = 0;
            // 
            // flowLayoutVehicles
            // 
            flowLayoutVehicles.AutoScroll = true;
            flowLayoutVehicles.Location = new Point(12, 350);
            flowLayoutVehicles.Name = "flowLayoutVehicles";
            flowLayoutVehicles.Size = new Size(400, 150);
            flowLayoutVehicles.TabIndex = 1;
            // 
            // btnMain
            // 
            btnMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMain.Location = new Point(12, 565);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(100, 54);
            btnMain.TabIndex = 2;
            btnMain.Text = "Main";
            btnMain.UseVisualStyleBackColor = true;
            btnMain.Click += btnMain_Click;
            // 
            // btnControls
            // 
            btnControls.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnControls.Location = new Point(223, 565);
            btnControls.Name = "btnControls";
            btnControls.Size = new Size(100, 54);
            btnControls.TabIndex = 3;
            btnControls.Text = "Controls";
            btnControls.UseVisualStyleBackColor = true;
            btnControls.Click += btnControls_Click;
            // 
            // btnCarInfo
            // 
            btnCarInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCarInfo.Location = new Point(117, 565);
            btnCarInfo.Name = "btnCarInfo";
            btnCarInfo.Size = new Size(100, 54);
            btnCarInfo.TabIndex = 4;
            btnCarInfo.Text = "Car Info";
            btnCarInfo.UseVisualStyleBackColor = true;
            btnCarInfo.Click += btnCarInfo_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSettings.Location = new Point(329, 565);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(100, 54);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 7F);
            dateTimePicker1.Location = new Point(0, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 20);
            dateTimePicker1.TabIndex = 6;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(163, 8);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(38, 15);
            labelTime.TabIndex = 7;
            labelTime.Text = "label1";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(334, 1);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(0, 0);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 23;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(405, 1);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 21);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 25;
            pictureBox13.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 2);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(21, 86);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 27;
            label1.Text = "Drivers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 312);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 28;
            label2.Text = "Vehicles";
            // 
            // timeZoneComboBox
            // 
            timeZoneComboBox.FormattingEnabled = true;
            timeZoneComboBox.Location = new Point(238, 3);
            timeZoneComboBox.Name = "timeZoneComboBox";
            timeZoneComboBox.Size = new Size(90, 23);
            timeZoneComboBox.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(371, 1);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(28, 21);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 45;
            pictureBox11.TabStop = false;
            // 
            // Controls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 631);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox1);
            Controls.Add(timeZoneComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(labelTime);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSettings);
            Controls.Add(btnCarInfo);
            Controls.Add(btnControls);
            Controls.Add(btnMain);
            Controls.Add(flowLayoutVehicles);
            Controls.Add(flowLayoutDrivers);
            Font = new Font("Segoe UI", 9F);
            Name = "Controls";
            Text = "Controls";
            Load += Controls_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutDrivers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutVehicles;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Button btnCarInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox timeZoneComboBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox11;
    }
}
