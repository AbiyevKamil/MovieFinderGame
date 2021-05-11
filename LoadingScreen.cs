using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFinderGame
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
            timerLoadingText.Start();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (progressbarLoading.Value < 100)
            {
                progressbarLoading.Value = progressbarLoading.Value + 1;

            }
            else
            {
                timerLoading.Stop();
                timerLoadingText.Stop();
                this.Hide();
                Main mainScreen = new Main();
                mainScreen.Show();
            }
        }

        private void timerLoadingText_Tick(object sender, EventArgs e)
        {
            if (labelLoading.Text == "Loading...")
            {
                labelLoading.Text = "Loading.";
            }
            else if (labelLoading.Text == "Loading..")
            {
                labelLoading.Text = "Loading...";
            }
            else if (labelLoading.Text == "Loading.")
            {
                labelLoading.Text = "Loading..";
            }
        }
    }
}
