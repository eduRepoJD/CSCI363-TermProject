using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSCI363Project.SettingsPage;

namespace CSCI363Project
{
    public partial class CarInfo : Form

    {
        private TimeZoneInfo selectedTimeZone = TimeZoneInfo.Local;
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
            label11.Text = convertedTime.ToString("hh:mm:ss tt");
        }


        private void updateGPSBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Alarm"])
            {
                MessageBox.Show("GPS has been updated");
            }

            else
            {
                MessageBox.Show("GPS Functionality is disabled");
            }
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
            if (selectedTimeZone != null)
            {
                DateTime localTime = DateTime.Now;
                DateTime convertedTime = TimeZoneInfo.ConvertTime(localTime, selectedTimeZone);
                label11.Text = convertedTime.ToString("hh:mm:ss tt");
            }
        }

        private void timeZoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeZoneComboBox.SelectedIndex >= 0)
            {
                string selectedTimeZoneName = timeZoneComboBox.SelectedItem?.ToString() ?? string.Empty;
                selectedTimeZone = TimeZoneInfo.GetSystemTimeZones()
                                               .FirstOrDefault(tz => tz.DisplayName == selectedTimeZoneName)
                                               ?? TimeZoneInfo.Local;
            }

        }

        public void SetFeatureAvailability(string feature, bool isEnabled)
        {
            if (feature == "GPS")
            {
                updateGPSBox.Enabled = isEnabled;
            }
        }
    }
}