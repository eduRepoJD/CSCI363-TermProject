﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSCI363Project.SettingsPage;

namespace CSCI363Project
{
    public partial class Controls : Form
    {

        private DriverInfo driver1;
        private DriverInfo driver2;
        private vehicleInfo vehicle1;
        private vehicleInfo vehicle2;

        private TimeZoneInfo selectedTimeZone = TimeZoneInfo.Local;

        public Controls()
        {
            InitializeComponent();
            InitializeDefaults();

            timer1.Interval = 1000;
            timer1.Start();

        }

        public void InitializeDefaults()
        {
            driver1 = new DriverInfo { Name = "Gavin Carlson", Age = 21 };
            driver2 = new DriverInfo { Name = "", Age = 0 };

            vehicle1 = new vehicleInfo { Make = "Ford", Model = "Raptor", Year = 2021 };
            vehicle2 = new vehicleInfo { Make = "", Model = "", Year = 0 };
        }

        private void Controls_Load(object sender, EventArgs e)
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
            label3.Text = convertedTime.ToString("hh:mm:ss tt");
        }


        private void driver1Box_Click(object sender, EventArgs e)
        {
            string info = $"Driver 1: {driver1.Name} Age: {driver1.Age}";
            MessageBox.Show(info, "Driver 1 Information");

        }

        private void driver2Box_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(driver2.Name))
            {
                MessageBox.Show("Driver 2 information is not available");
            }
            else
            {
                string info = $"Driver 2: {driver2.Name} Age: {driver2.Age}";
                MessageBox.Show(info, "Driver 2 Information");
            }
        }
        private void addDriverBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Alarm"])
            {

            }

            else
            {
                MessageBox.Show("Add Driver Functionality is disabled");
            }
        }

        private void vehicle1Box_Click(object sender, EventArgs e)
        {
            string info = $"Vehicle 1: {vehicle1.Make}, Model: {vehicle1.Model}, Year: {vehicle1.Year}";
            MessageBox.Show(info, "Vehicle 1 Information");
        }

        private void vehicle2Box_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicle2.Make))
            {
                MessageBox.Show("Vehicle 2 information is not available");
            }
            else
            {
                string info = $"Vehicle 2: {vehicle2.Make} , Model:  {vehicle2.Model} , Year:  {vehicle2.Year}";
                MessageBox.Show(info, "Vehicle 2 Information");
            }
        }

        private void addVehicleBox_Click(object sender, EventArgs e)
        {
            if (FeatureManager.featureStates["Alarm"])
            {

            }

            else
            {
                MessageBox.Show("Add Vehicle Functionality is disabled");
            }
        }
        public class DriverInfo
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class vehicleInfo
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
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
                label3.Text = convertedTime.ToString("hh:mm:ss tt");
            }
        }

        private void timeZoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeZoneComboBox.SelectedIndex != null)
            {
                string selectedTimeZoneName = timeZoneComboBox.SelectedItem.ToString();
                selectedTimeZone = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.DisplayName == selectedTimeZoneName);
            }
        }

        public void SetFeatureAvailability(string feature, bool isEnabled)
        {
            switch (feature)
            {
                case "Add Driver":
                    addDriverBox.Enabled = isEnabled;
                    break;

                case "Add Vehicle":
                    addVehicleBox.Enabled = isEnabled;
                    break;
            }
        }
    }
}
