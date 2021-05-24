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
    public partial class CongratsForm : Form
    {
        string username;
        int score;
        public CongratsForm(string username,int score)
        {
            InitializeComponent();
            this.username = username;
            this.score = score;
        }

        private void CongratsForm_Load(object sender, EventArgs e)
        {
            labelYourScore.Text = "Congratulations, " + username + "." + "Your score: " + score;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
