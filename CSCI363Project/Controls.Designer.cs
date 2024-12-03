namespace CSCI363Project
{
    partial class Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            panel1 = new Panel();
            driver2Box = new PictureBox();
            addDriverBox = new PictureBox();
            vehicle1Box = new PictureBox();
            vehicle2Box = new PictureBox();
            addVehicleBox = new PictureBox();
            driver1Box = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            settingsBox = new Button();
            controlsBox = new Button();
            carInfoBox = new Button();
            mainBox = new Button();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timeZoneComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)driver2Box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addDriverBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehicle1Box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehicle2Box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addVehicleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driver1Box).BeginInit();
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
            panel1.TabIndex = 19;
            // 
            // driver2Box
            // 
            driver2Box.BorderStyle = BorderStyle.Fixed3D;
            driver2Box.Image = (Image)resources.GetObject("driver2Box.Image");
            driver2Box.Location = new Point(141, 96);
            driver2Box.Name = "driver2Box";
            driver2Box.Size = new Size(118, 91);
            driver2Box.SizeMode = PictureBoxSizeMode.StretchImage;
            driver2Box.TabIndex = 44;
            driver2Box.TabStop = false;
            driver2Box.Click += driver2Box_Click;
            // 
            // addDriverBox
            // 
            addDriverBox.BorderStyle = BorderStyle.Fixed3D;
            addDriverBox.Image = (Image)resources.GetObject("addDriverBox.Image");
            addDriverBox.Location = new Point(287, 96);
            addDriverBox.Name = "addDriverBox";
            addDriverBox.Size = new Size(111, 91);
            addDriverBox.SizeMode = PictureBoxSizeMode.StretchImage;
            addDriverBox.TabIndex = 43;
            addDriverBox.TabStop = false;
            addDriverBox.Click += addDriverBox_Click;
            // 
            // vehicle1Box
            // 
            vehicle1Box.BorderStyle = BorderStyle.Fixed3D;
            vehicle1Box.Image = (Image)resources.GetObject("vehicle1Box.Image");
            vehicle1Box.Location = new Point(11, 340);
            vehicle1Box.Name = "vehicle1Box";
            vehicle1Box.Size = new Size(114, 87);
            vehicle1Box.SizeMode = PictureBoxSizeMode.StretchImage;
            vehicle1Box.TabIndex = 42;
            vehicle1Box.TabStop = false;
            vehicle1Box.Click += vehicle1Box_Click;
            // 
            // vehicle2Box
            // 
            vehicle2Box.BorderStyle = BorderStyle.Fixed3D;
            vehicle2Box.Image = (Image)resources.GetObject("vehicle2Box.Image");
            vehicle2Box.Location = new Point(141, 340);
            vehicle2Box.Name = "vehicle2Box";
            vehicle2Box.Size = new Size(118, 87);
            vehicle2Box.SizeMode = PictureBoxSizeMode.StretchImage;
            vehicle2Box.TabIndex = 41;
            vehicle2Box.TabStop = false;
            vehicle2Box.Click += vehicle2Box_Click;
            // 
            // addVehicleBox
            // 
            addVehicleBox.BorderStyle = BorderStyle.Fixed3D;
            addVehicleBox.Image = (Image)resources.GetObject("addVehicleBox.Image");
            addVehicleBox.Location = new Point(287, 340);
            addVehicleBox.Name = "addVehicleBox";
            addVehicleBox.Size = new Size(111, 87);
            addVehicleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            addVehicleBox.TabIndex = 40;
            addVehicleBox.TabStop = false;
            addVehicleBox.Click += addVehicleBox_Click;
            // 
            // driver1Box
            // 
            driver1Box.BorderStyle = BorderStyle.Fixed3D;
            driver1Box.Image = (Image)resources.GetObject("driver1Box.Image");
            driver1Box.Location = new Point(11, 96);
            driver1Box.Name = "driver1Box";
            driver1Box.Size = new Size(114, 91);
            driver1Box.SizeMode = PictureBoxSizeMode.StretchImage;
            driver1Box.TabIndex = 39;
            driver1Box.TabStop = false;
            driver1Box.Click += driver1Box_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(-12, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 2);
            panel2.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(11, 297);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 38;
            label2.Text = "Vehicles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 37;
            label1.Text = "Drivers";
            // 
            // settingsBox
            // 
            settingsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBox.Location = new Point(331, 494);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new Size(100, 54);
            settingsBox.TabIndex = 56;
            settingsBox.Text = "Settings";
            settingsBox.UseVisualStyleBackColor = true;
            settingsBox.Click += settingsBox_Click;
            // 
            // controlsBox
            // 
            controlsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlsBox.Location = new Point(225, 494);
            controlsBox.Name = "controlsBox";
            controlsBox.Size = new Size(100, 54);
            controlsBox.TabIndex = 55;
            controlsBox.Text = "Controls";
            controlsBox.UseVisualStyleBackColor = true;
            // 
            // carInfoBox
            // 
            carInfoBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carInfoBox.Location = new Point(119, 494);
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
            mainBox.Location = new Point(14, 494);
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
            dateTimePicker1.Location = new Point(2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 20);
            dateTimePicker1.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(415, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(344, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(381, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 7);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 61;
            label3.Text = "label3";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timeZoneComboBox
            // 
            timeZoneComboBox.FormattingEnabled = true;
            timeZoneComboBox.Location = new Point(248, 3);
            timeZoneComboBox.Name = "timeZoneComboBox";
            timeZoneComboBox.Size = new Size(90, 23);
            timeZoneComboBox.TabIndex = 62;
            timeZoneComboBox.SelectedIndexChanged += timeZoneComboBox_SelectedIndexChanged;
            // 
            // Controls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(445, 560);
            Controls.Add(timeZoneComboBox);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(settingsBox);
            Controls.Add(controlsBox);
            Controls.Add(carInfoBox);
            Controls.Add(mainBox);
            Controls.Add(driver2Box);
            Controls.Add(addDriverBox);
            Controls.Add(panel1);
            Controls.Add(vehicle1Box);
            Controls.Add(vehicle2Box);
            Controls.Add(addVehicleBox);
            Controls.Add(driver1Box);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Controls";
            Text = "Controls";
            Load += Controls_Load;
            ((System.ComponentModel.ISupportInitialize)driver2Box).EndInit();
            ((System.ComponentModel.ISupportInitialize)addDriverBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehicle1Box).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehicle2Box).EndInit();
            ((System.ComponentModel.ISupportInitialize)addVehicleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)driver1Box).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox driver2Box;
        private PictureBox addDriverBox;
        private PictureBox vehicle1Box;
        private PictureBox vehicle2Box;
        private PictureBox addVehicleBox;
        private PictureBox driver1Box;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button settingsBox;
        private Button controlsBox;
        private Button carInfoBox;
        private Button mainBox;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ComboBox timeZoneComboBox;
    }
}