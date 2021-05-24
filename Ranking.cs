using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MovieFinderGame
{
    public partial class Ranking : Form
    {

        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            List<string> users = new List<string>();
            List<int> scores = new List<int>();

            DirectoryInfo getUsernames = new DirectoryInfo(@".\Data");
            DirectoryInfo[] usernames = getUsernames.GetDirectories();
            foreach (DirectoryInfo username in usernames)
            {
                users.Add(username.Name);
            }
            for (int i = 0; i < users.Count(); i++)
            {
                string scoresPath = @"Data\" + users[i] + @"\" + "scores.dll";
                if (File.Exists(scoresPath))
                {
                    StreamReader scoreReader = new StreamReader(scoresPath);
                    int score = int.Parse(scoreReader.ReadLine());
                    scores.Add(score);
                    scoreReader.Close();
                }
                else
                {
                    scores.Add(0);
                }
            }
            List<User> userList = new List<User>();
            for (int i = 0; i < users.Count(); i++)
                userList.Add(new User(scores[i], users[i]));
            userList.Sort(new Sorter());
            for (int i = 0; i < userList.Count(); i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Selected = false;
                lvi.Text = userList[i].username;
                lvi.SubItems.Add(userList[i].score.ToString());
                listViewRanking.Items.Add(lvi);
            }
        }

    }
}