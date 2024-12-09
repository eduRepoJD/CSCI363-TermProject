using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI363Project
{
    public partial class DriverInfo : Form
    {
        public string? DriverName { get; set; }
        public int? DriverAge { get; set; }
        public bool IsSaved { get; private set; } = false;

        public DriverInfo()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            textBoxName.GotFocus += ClearOnFocus;
            textBoxAge.GotFocus += ClearOnFocus;
        }

        public void SetDriverInfo(string name, int age)
        {
            textBoxName.Text = name;
            textBoxAge.Text = age.ToString();
        }

        private void ClearOnFocus(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Tag == null)
                {
                    textBox.Tag = true; // Mark that this box has been modified
                    textBox.Clear();
                }
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                !int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("Please enter valid driver details.", "Validation Error");
                return;
            }

            DriverName = textBoxName.Text;
            DriverAge = age;
            IsSaved = true;
            this.Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
