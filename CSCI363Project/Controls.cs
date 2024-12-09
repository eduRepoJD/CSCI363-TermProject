using System;
using System.CodeDom;
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

namespace CSCI363Project
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
            ApplyCurrentTheme();
            timer1.Start();
        }
        private void ApplyCurrentTheme()
        {
            this.BackColor = ThemeManager.CurrentBackColor;

            foreach (Control ctrl in Controls)
            {
                // Exclude navigation buttons from theme changes
                if (ctrl == btnMain || ctrl == btnCarInfo || ctrl == btnControls || ctrl == btnSettings)
                {
                    continue;
                }

                // Change ForeColor for other controls
                if (ctrl is Button || ctrl is System.Windows.Forms.Label)
                {
                    ctrl.ForeColor = ThemeManager.CurrentLabelColor;
                }
            }
        }


        private void Controls_Load(object sender, EventArgs e)
        {
            RefreshDriverIcons();
            RefreshVehicleIcons();
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnMain_Click(object? sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void btnControls_Click(object? sender, EventArgs e)
        {
            // Already on Controls, no action needed
        }

        private void btnCarInfo_Click(object? sender, EventArgs e)
        {
            CarInfo carInfo = new CarInfo();
            carInfo.Show();
            this.Close();
        }

        private void btnSettings_Click(object? sender, EventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();
            settingsPage.Show();
            this.Close();
        }

        private void RefreshDriverIcons()
        {
            flowLayoutDrivers.Controls.Clear();

            for (int i = 0; i < DataManager.Drivers.Count; i++)
            {
                var driver = DataManager.Drivers[i];
                Panel driverPanel = new Panel
                {
                    Size = new Size(100, 100),
                    BorderStyle = BorderStyle.Fixed3D,
                };

                var driverLabel = new System.Windows.Forms.Label
                {
                    Text = $"{driver.DriverName}\nAge: {driver.DriverAge}",
                    AutoSize = false,
                    Font = new Font("Segoe UI", 10F), 
                    ForeColor = Color.Black, 
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(100, 70), 
                    Location = new Point(0,0) 
                };


                Button editButton = new Button
                {
                    Text = "Edit",
                    Size = new Size(50, 20),
                    Location = new Point(-1, 75),
                    Tag = i // Attach index as Tag
                };
                editButton.Click += (s, e) =>
                {
                    if (editButton.Tag is int index) // Null-safe unboxing
                    {
                        EditDriver(index);
                    }
                };

                Button deleteButton = new Button
                {
                    Text = "Delete",
                    Size = new Size(50, 20),
                    Location = new Point(47, 75),
                    Tag = i // Attach index as Tag
                };
                deleteButton.Click += (s, e) =>
                {
                    if (deleteButton.Tag is int index) // Null-safe unboxing
                    {
                        DeleteDriver(index);
                    }
                };

                driverPanel.Controls.Add(driverLabel);
                driverPanel.Controls.Add(editButton);
                driverPanel.Controls.Add(deleteButton);

                flowLayoutDrivers.Controls.Add(driverPanel);
            }

            Button addDriverButton = new Button
            {
                Text = "+",
                Font = new Font("Segoe UI", 30F),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(50, 50)
            };
            addDriverButton.Click += AddDriverButton_Click;
            flowLayoutDrivers.Controls.Add(addDriverButton);
        }

        private void RefreshVehicleIcons()
        {
            flowLayoutVehicles.Controls.Clear();

            for (int i = 0; i < DataManager.Vehicles.Count; i++)
            {
                var vehicle = DataManager.Vehicles[i];
                Panel vehiclePanel = new Panel
                {
                    Size = new Size(100, 100),
                    BorderStyle = BorderStyle.Fixed3D
                };

                var vehicleLabel = new System.Windows.Forms.Label
                {
                    Text = $"{vehicle.Make} {vehicle.Model}\nYear: {vehicle.Year}",
                    AutoSize = false,
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(100, 70),
                    Location = new Point(0, 0)
                };

                Button editButton = new Button
                {
                    Text = "Edit",
                    Size = new Size(50, 20),
                    Location = new Point(-1, 75),
                    Tag = i // Attach index as Tag
                };
                editButton.Click += (s, e) =>
                {
                    if (editButton.Tag is int index) // Null-safe unboxing
                    {
                        EditVehicle(index);
                    }
                };

                Button deleteButton = new Button
                {
                    Text = "Delete",
                    Size = new Size(50, 20),
                    Location = new Point(47, 75),
                    Tag = i // Attach index as Tag
                };
                deleteButton.Click += (s, e) =>
                {
                    if (deleteButton.Tag is int index) // Null-safe unboxing
                    {
                        DeleteVehicle(index);
                    }
                };

                vehiclePanel.Controls.Add(vehicleLabel);
                vehiclePanel.Controls.Add(editButton);
                vehiclePanel.Controls.Add(deleteButton);

                flowLayoutVehicles.Controls.Add(vehiclePanel);
            }

            Button addVehicleButton = new Button
            {
                Text = "+",
                Font = new Font("Segoe UI", 30F),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(50, 50)
            };
            addVehicleButton.Click += AddVehicleButton_Click;
            flowLayoutVehicles.Controls.Add(addVehicleButton);
        }

        private void AddDriverButton_Click(object? sender, EventArgs e)
        {
            DriverInfo driverForm = new DriverInfo();
            driverForm.ShowDialog();

            if (driverForm.IsSaved)
            {
                DataManager.AddDriver(new DriverInfo
                {
                    DriverName = driverForm.DriverName,
                    DriverAge = driverForm.DriverAge
                });

                RefreshDriverIcons();
            }
        }

        private void AddVehicleButton_Click(object? sender, EventArgs e)
        {
            VehicleInfo vehicleForm = new VehicleInfo();
            vehicleForm.ShowDialog();

            if (vehicleForm.IsSaved)
            {
                DataManager.AddVehicle(new VehicleInfo
                {
                    Make = vehicleForm.Make,
                    Model = vehicleForm.Model,
                    Year = vehicleForm.Year
                });

                RefreshVehicleIcons();
            }
        }

        private void EditDriver(int index)
        {
            if (index < 0 || index >= DataManager.Drivers.Count)
            {
                MessageBox.Show("Invalid driver selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DriverInfo driverForm = new DriverInfo();
            // Pass existing data to the DriverInfo form
            driverForm.SetDriverInfo(
                DataManager.Drivers[index].DriverName ?? string.Empty,
                DataManager.Drivers[index].DriverAge ?? 0
            );
            driverForm.ShowDialog();

            if (driverForm.IsSaved)
            {
                // Update the driver information in DataManager
                DataManager.UpdateDriver(index, new DriverInfo
                {
                    DriverName = driverForm.DriverName,
                    DriverAge = driverForm.DriverAge
                });

                RefreshDriverIcons();
            }
        }


        private void DeleteDriver(int index)
        {
            if (index < 0 || index >= DataManager.Drivers.Count)
            {
                MessageBox.Show("Invalid driver selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataManager.RemoveDriver(index);
                RefreshDriverIcons();
            }
        }

        private void EditVehicle(int index)
        {
            if (index < 0 || index >= DataManager.Vehicles.Count)
            {
                MessageBox.Show("Invalid vehicle selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VehicleInfo vehicleForm = new VehicleInfo();
            // Pass existing data to the VehicleInfo form
            vehicleForm.SetVehicleInfo(
                DataManager.Vehicles[index].Make ?? string.Empty,
                DataManager.Vehicles[index].Model ?? string.Empty,
                DataManager.Vehicles[index].Year ?? 0
            );
            vehicleForm.ShowDialog();

            if (vehicleForm.IsSaved)
            {
                // Update the vehicle information in DataManager
                DataManager.UpdateVehicle(index, new VehicleInfo
                {
                    Make = vehicleForm.Make,
                    Model = vehicleForm.Model,
                    Year = vehicleForm.Year
                });

                RefreshVehicleIcons();
            }
        }


        private void DeleteVehicle(int index)
        {
            if (index < 0 || index >= DataManager.Vehicles.Count)
            {
                MessageBox.Show("Invalid vehicle selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataManager.RemoveVehicle(index);
                RefreshVehicleIcons();
            }
        }

        public void SetFeatureAvailability(string feature, bool isEnabled)
        {
            if (feature == "day")
            {
                // Apply daytime mode if enabled, nighttime mode if not
                this.BackColor = isEnabled ? Color.White : Color.Black;

                foreach (Control control in this.Controls)
                {
                    // Use fully qualified name to avoid ambiguity with 'Label'
                    if (control is System.Windows.Forms.Label || control is Button)
                    {
                        control.ForeColor = isEnabled ? Color.Black : Color.White;
                    }
                }
            }
            else if (feature == "night")
            {
                // Apply nighttime mode if enabled (same logic as above, but explicitly checks for "night")
                this.BackColor = isEnabled ? Color.Black : Color.White;

                foreach (Control control in this.Controls)
                {
                    // Use fully qualified name to avoid ambiguity with 'Label'
                    if (control is System.Windows.Forms.Label || control is Button)
                    {
                        control.ForeColor = isEnabled ? Color.White : Color.Black;
                    }
                }
            }
        }

    }
}
