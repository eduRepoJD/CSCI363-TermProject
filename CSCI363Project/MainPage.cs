using System;
using System.Drawing.Text;
using System.Windows.Forms;
using static CSCI363Project.SettingsPage;

namespace CSCI363Project
{
    public partial class MainPage : Form
    {
        private static bool engineOn = false;
        private static bool alarmOn = false;
        private static bool doorsLocked = false;
        private static bool sunroofOpen = false;
        private static bool windowsUp = true;

        private TimeZoneInfo selectedTimeZone = TimeZoneInfo.Local;

        public MainPage()
        {
            InitializeComponent();
            this.Load += MainPage_Load;
            ApplyCurrentTheme();

            timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;
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

        private void MainPage_Load(object? sender, EventArgs e)
        {
            foreach (TimeZoneInfo tz in TimeZoneInfo.GetSystemTimeZones())
            {
                timeZoneComboBox.Items.Add(tz.DisplayName);
            }
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            string localDisplayName = localTimeZone.DisplayName;

            int localIndex = timeZoneComboBox.Items.IndexOf(localDisplayName);
            if (localIndex != -1)
            {
                timeZoneComboBox.SelectedIndex = localIndex;
            }

            UpdateTimeLabel(localTimeZone);
        }
        private void UpdateTimeLabel(TimeZoneInfo timezone)
        {
            DateTime localTime = DateTime.Now;
            DateTime convertedTime = TimeZoneInfo.ConvertTime(localTime, timezone);
            label6.Text = convertedTime.ToString("hh:mm:ss tt");
        }

        private void engineBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Start/Stop Engine"])
            {
                engineOn = !engineOn;
                MessageBox.Show(engineOn ? "Engine is now ON" : "Engine is now OFF", "Engine Status");
            }
            else
            {
                MessageBox.Show("Engine Functionality is disabled");
            }

        }

        private void doorBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Lock/Unlock Doors"])
            {
                doorsLocked = !doorsLocked;
                MessageBox.Show(doorsLocked ? "Doors are now Locked" : "Doors are now Unlocked", "Door Status");
            }
            else
            {
                MessageBox.Show("Door Functionality is disabled");
            }

        }

        private void upWindowBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Windows"])
            {
                if (windowsUp)
                {
                MessageBox.Show("Windows are already up");
                }
                else
                {
                    windowsUp = true;
                    MessageBox.Show("Windows has been rolled up");
                }
            }

            else
            {
                MessageBox.Show("Window Functionality is disabled");
            }
            


        }

        private void downWindowBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Windows"])
            {
                if (!windowsUp)
                {
                    MessageBox.Show("Windows are already down");
                }
                else
                {
                    windowsUp = false;
                    MessageBox.Show("Windows has been rolled down");
                }
            }
            
            else
            {
                MessageBox.Show("Window Functionality is disabled");
            }
        }

        private void sunroofBox_Click(object sender, EventArgs e)
        {
            sunroofOpen = !sunroofOpen;
            MessageBox.Show(sunroofOpen ? "Sunroof has been opened" : "Sunroof has been closed", "Sunroof Status");

        }

        private void alarmBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Alarm"])
            {
                alarmOn = !alarmOn;
                MessageBox.Show(alarmOn ? "Alarm has been turned on" : "Alarm has been turned off", "Alarm Status");
            }

            else
            {
                MessageBox.Show("Alarm Functionality is disabled");
            }
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
            if (selectedTimeZone != null)
            {
                DateTime localTime = DateTime.Now;
                DateTime convertedTime = TimeZoneInfo.ConvertTime(localTime, selectedTimeZone);
                label6.Text = convertedTime.ToString("hh:mm:ss tt");
            }
            
        }

        private void timeZoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeZoneComboBox.SelectedIndex >= 0)
            {
                string selectedTimeZoneName = timeZoneComboBox.SelectedItem?.ToString() ?? "Default Time Zone";
                selectedTimeZone = TimeZoneInfo.GetSystemTimeZones()
                                               .FirstOrDefault(tz => tz.DisplayName == selectedTimeZoneName)
                                               ?? TimeZoneInfo.Local;
            }
        }

        public void SetFeatureAvailability(string feature, bool isEnabled)
        {
            switch (feature)
            {
                case "Start/Stop Engine":
                    engineBox.Enabled = isEnabled; 
                    break;

                case "Lock/Unlock Doors":
                    doorBox.Enabled = isEnabled;
                    break;

                case "Windows":
                    upWindowBox.Enabled = isEnabled;
                    downWindowBox.Enabled = isEnabled;
                    break;

                case "Alarm":
                    alarmBox.Enabled = isEnabled;
                    break;
            }
        }
    }
}
