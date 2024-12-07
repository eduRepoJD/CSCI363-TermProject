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
    public partial class CarInfo : Form
    {
        public CarInfo()
        {
            InitializeComponent();
            ApplyCurrentTheme();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void ApplyCurrentTheme()
        {
            this.BackColor = ThemeManager.CurrentBackColor;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.BackColor = ThemeManager.CurrentTextBoxBackColor;
                    textBox.ForeColor = ThemeManager.CurrentTextBoxForeColor;
                }
            }
        }

        private void CarInfo_Load(object sender, EventArgs e)
        {
            // Initialization code for when the form loads
        }

        private void updateGPSBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GPS has been updated");
        }

        private void mainBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void controlsBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controls controlsForm = new Controls();
            controlsForm.Show();
        }

        private void settingsBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsPage settingsForm = new SettingsPage();
            settingsForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}