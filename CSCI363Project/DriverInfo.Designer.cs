namespace CSCI363Project
{
    partial class DriverInfo
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 291);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 9;
            label3.Text = "Enter Vehicle Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 106);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 8;
            label2.Text = "Enter Driver Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 7;
            label1.Text = "Driver Information";
            // 
            // button1
            // 
            button1.Location = new Point(633, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(633, 189);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(633, 291);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // DriverInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DriverInfo";
            Text = "DriverInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}