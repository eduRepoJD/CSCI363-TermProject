using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI363Project
{
    public partial class SettingsPage : Form
    {
        private TimeZoneInfo selectedTimeZone = TimeZoneInfo.Local;
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


        public static class FeatureManager
        {
            public static Dictionary<string, bool> featureStates = new Dictionary<string, bool>
            {
                {"Start/Stop Engine", true},
                {"Lock/Unlock Doors", true},
                {"Windows", true},
                {"Alarm", true},
                {"GPS", true},
                {"Add Driver", true},
                {"Add Vehicle", true},
            };
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
            if (selectedTimeZone != null)
            {
                DateTime localTime = DateTime.Now;
                DateTime convertedTime = TimeZoneInfo.ConvertTime(localTime, selectedTimeZone);
                label4.Text = convertedTime.ToString("hh:mm:ss tt");
            }
        }

        private void timeZoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeZoneComboBox.SelectedIndex >= 0)
            {
                string selectedTimeZoneName = timeZoneComboBox.SelectedItem?.ToString();
                selectedTimeZone = TimeZoneInfo.GetSystemTimeZones()
                                               .FirstOrDefault(tz => tz.DisplayName == selectedTimeZoneName)
                                               ?? TimeZoneInfo.Local;
            }
        }

        private void SettingsPage_Load_1(object sender, EventArgs e)
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
            checkedListBox1.Items.Clear();

            foreach (var feature in FeatureManager.featureStates)
            {
                checkedListBox1.Items.Add(feature.Key, feature.Value);
            }
        }
        private void UpdateTimeLabel(TimeZoneInfo timezone)
        {
            DateTime localTime = DateTime.Now;
            DateTime convertedTime = TimeZoneInfo.ConvertTime(localTime, timezone);
            label4.Text = convertedTime.ToString("hh:mm:ss tt");
        }


        private void UpdateFeatureAvailability(string feature, bool isEnabled)
        {
            if (this.Owner is MainPage mainpage)
            {
                mainpage.SetFeatureAvailability(feature, isEnabled);
            }

            if (this.Owner is CarInfo carInfo)
            {
                carInfo.SetFeatureAvailability(feature, isEnabled);
            }
            if (this.Owner is Controls controls)
            {
                controls.SetFeatureAvailability(feature, isEnabled);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string feature = checkedListBox1.Items[e.Index].ToString();
            bool isEnabled = e.NewValue == CheckState.Checked;

            if (FeatureManager.featureStates.ContainsKey(feature))
            {
                FeatureManager.featureStates[feature] = isEnabled;
            }

            UpdateFeatureAvailability(feature, isEnabled);
        }
    }
}
