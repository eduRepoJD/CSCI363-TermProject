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
    public partial class VehicleInfo : Form
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public bool IsSaved { get; private set; } = false;

        public VehicleInfo()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            textBoxMake.GotFocus += ClearOnFocus;
            textBoxModel.GotFocus += ClearOnFocus;
            textBoxYear.GotFocus += ClearOnFocus;
        }

        public void SetVehicleInfo(string make, string model, int year)
        {
            textBoxMake.Text = make;
            textBoxModel.Text = model;
            textBoxYear.Text = year.ToString();
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
            if (string.IsNullOrWhiteSpace(textBoxMake.Text) ||
                string.IsNullOrWhiteSpace(textBoxModel.Text) ||
                !int.TryParse(textBoxYear.Text, out int year))
            {
                MessageBox.Show("Please enter valid vehicle details.", "Validation Error");
                return;
            }

            Make = textBoxMake.Text;
            Model = textBoxModel.Text;
            Year = year;
            IsSaved = true;
            this.Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
