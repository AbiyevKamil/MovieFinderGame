using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Random;

namespace MovieFInderApp
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private string generateGuestUsername()
        {
            Random random = new Random();
            string username = "Guest" + random.Next(10000, 9999999);
            return username;
        }

        private void buttonPlayasaGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game gamePage = new Game(generateGuestUsername());
            gamePage.Show();
        }

        private void buttonLoginandPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerPage = new Register();
            registerPage.Show();
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            Ranking rankingPage = new Ranking();
            rankingPage.ShowDialog();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
