using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void updateAppBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application has restarted");
        }

        private void dayTimeBox_Click(object sender, EventArgs e)
        {

        }

        private void nightTimeBox_Click(object sender, EventArgs e)
        {

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
