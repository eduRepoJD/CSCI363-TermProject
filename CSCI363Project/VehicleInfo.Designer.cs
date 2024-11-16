namespace CSCI363Project
{
    partial class VehicleInfo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 36);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Vehicle Make:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 218);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Vehicle Model:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 347);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 5;
            label4.Text = "Enter Vehicle Year:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 339);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(620, 324);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(620, 222);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(620, 112);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // VehicleInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VehicleInfo";
            Text = "VehicleInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}