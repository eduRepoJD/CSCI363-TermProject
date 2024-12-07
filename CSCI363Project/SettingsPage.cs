using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSCI363Project
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            ApplyCurrentTheme();
        }

        private void ApplyCurrentTheme()
        {
            this.BackColor = ThemeManager.CurrentBackColor;
            label4.ForeColor = ThemeManager.CurrentLabelColor;

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

        private void updateAppBox_Click(object sender, EventArgs e)
        {
            ApplyCurrentTheme();
            MessageBox.Show("Application has restarted");
        }

        private void dayTimeBox_Click(object sender, EventArgs e)
        {
            ThemeManager.CurrentBackColor = Color.White;
            ThemeManager.CurrentLabelColor = Color.Black;
            ThemeManager.CurrentTextBoxBackColor = Color.White;
            ThemeManager.CurrentTextBoxForeColor = Color.Black;
            ApplyCurrentTheme();
        }

        private void nightTimeBox_Click(object sender, EventArgs e)
        {
            ThemeManager.CurrentBackColor = Color.DimGray;  // Darker grey
            ThemeManager.CurrentLabelColor = Color.White;
            ThemeManager.CurrentTextBoxBackColor = Color.Gray;
            ThemeManager.CurrentTextBoxForeColor = Color.White;
            ApplyCurrentTheme();
        }

        private void mainBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void carInfoBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarInfo carInfoForm = new CarInfo();
            carInfoForm.Show();
        }

        private void controlsBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controls controlsForm = new Controls();
            controlsForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
