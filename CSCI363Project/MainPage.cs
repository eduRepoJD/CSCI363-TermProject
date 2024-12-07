using System;
using System.Windows.Forms;

namespace CSCI363Project
{
    public partial class MainPage : Form
    {
        private static bool engineOn = false;
        private static bool alarmOn = false;
        private static bool doorsLocked = false;
        private static bool sunroofOpen = false;
        private static bool windowsUp = true;

        public MainPage()
        {
            InitializeComponent();
            ApplyCurrentTheme();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void ApplyCurrentTheme()
        {
            this.BackColor = ThemeManager.CurrentBackColor;
            label6.ForeColor = ThemeManager.CurrentLabelColor;

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

        private void engineBox_Click(object sender, EventArgs e)
        {
            engineOn = !engineOn;
            MessageBox.Show(engineOn ? "Engine is now ON" : "Engine is now OFF", "Engine Status");
        }

        private void doorBox_Click(object sender, EventArgs e)
        {
            doorsLocked = !doorsLocked;
            MessageBox.Show(doorsLocked ? "Doors are now Locked" : "Doors are now Unlocked", "Door Status");
        }

        private void upWindowBox_Click(object sender, EventArgs e)
        {
            if (windowsUp)
            {
                MessageBox.Show("Windows are already up");
            }
            else
            {
                windowsUp = true;
                MessageBox.Show("Windows have been rolled up");
            }
        }

        private void downWindowBox_Click(object sender, EventArgs e)
        {
            if (!windowsUp)
            {
                MessageBox.Show("Windows are already down");
            }
            else
            {
                windowsUp = false;
                MessageBox.Show("Windows have been rolled down");
            }
        }

        private void sunroofBox_Click(object sender, EventArgs e)
        {
            sunroofOpen = !sunroofOpen;
            MessageBox.Show(sunroofOpen ? "Sunroof has been opened" : "Sunroof has been closed", "Sunroof Status");
        }

        private void alarmBox_Click(object sender, EventArgs e)
        {
            alarmOn = !alarmOn;
            MessageBox.Show(alarmOn ? "Alarm has been turned on" : "Alarm has been turned off", "Alarm Status");
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

        private void settingsBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsPage settingsForm = new SettingsPage();
            settingsForm.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
