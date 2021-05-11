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
    public partial class InformationBox : Form
    {
        public InformationBox()
        {
            InitializeComponent();
        }

        private void linkLabelRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelRepo.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/abiyevkamil1903/MovieFinderGame");
        }

    }
}
