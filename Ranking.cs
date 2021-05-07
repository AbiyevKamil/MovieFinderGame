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

namespace MovieFInderApp
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
                userList.Add(new User(scores[i],users[i]));
            userList.Sort(new Sorter());
            for (int i = 0; i < userList.Count(); i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Selected = false;
                lvi.UseItemStyleForSubItems = false;
                lvi.Text = userList[i].username;
                lvi.SubItems.Add(userList[i].score.ToString());
                listViewRanking.Items.Add(lvi);
            }
        }

    }
}


/*

        List<string> usersData = new List<string>();
        List<string> users = new List<string>();
        List<int> scores = new List<int>();
        List<string> hundreds = new List<string>();
        List<string> nineties = new List<string>();
        List<string> eighties = new List<string>();
        List<string> seventies = new List<string>();
        List<string> sixties = new List<string>();
        List<string> fifties = new List<string>();
        List<string> fourties = new List<string>();
        List<string> thirties = new List<string>();
        List<string> twenties = new List<string>();
        List<string> tens = new List<string>();
        List<string> zeros = new List<string>();

//string rankingPath = @"\data\ranking"; 
//StreamReader scoreReader = new StreamReader(rankingPath);

DirectoryInfo getUsernames = new DirectoryInfo(@".\Data");
DirectoryInfo[] usernames = getUsernames.GetDirectories();
foreach (DirectoryInfo username in usernames)
{
    users.Add(username.Name);
}
for (int i = 0; i < users.Count(); i++)
{
    string scoresPath = @"Data\" + users[i] + @"\" + "scores.dll";
    //MessageBox.Show(scoresPath);
    if (File.Exists(scoresPath))
    {
        StreamReader scoreReader = new StreamReader(scoresPath);
        int score = int.Parse(scoreReader.ReadLine());
        scores.Add(score);
        MessageBox.Show("Username: " + users[i] + " Score: " + score);
        scoreReader.Close();
    } else
    {
        scores.Add(0);
    }
}

// Creating Data

for (int i = 0; i < users.Count(); i++)
{
    usersData.Add(users[i]);
    usersData.Add(scores[i].ToString());
}

// Sorting Data

for (int i = 0; i < users.Count(); i++)
{
    if (scores[i] == 100)
    {
        hundreds.Add(users[i]);
        hundreds.Add(scores[i].ToString());
    }
    else if (scores[i] == 90)
    {
        nineties.Add(users[i]);
        nineties.Add(scores[i].ToString());
    }
    else if (scores[i] == 80)
    {
        eighties.Add(users[i]);
        eighties.Add(scores[i].ToString());
    }
    else if (scores[i] == 70)
    {
        seventies.Add(users[i]);
        seventies.Add(scores[i].ToString());
    }
    else if (scores[i] == 60)
    {
        sixties.Add(users[i]);
        sixties.Add(scores[i].ToString());
    }
    else if (scores[i] == 50)
    {
        fifties.Add(users[i]);
        fifties.Add(scores[i].ToString());
    }
    else if (scores[i] == 40)
    {
        fourties.Add(users[i]);
        fourties.Add(scores[i].ToString());
    }
    else if (scores[i] == 30)
    {
        thirties.Add(users[i]);
        thirties.Add(scores[i].ToString());
    }
    else if (scores[i] == 20)
    {
        twenties.Add(users[i]);
        twenties.Add(scores[i].ToString());
    }
    else if (scores[i] == 10)
    {
        tens.Add(users[i]);
        tens.Add(scores[i].ToString());
    }
    else if (scores[i] == 0)
    {
        zeros.Add(users[i]);
        zeros.Add(scores[i].ToString());
    }
}
//MessageBox.Show(String.Join(", ",hundreds));
//MessageBox.Show(hundreds.Count().ToString());
for (int i = 0; i < users.Count(); i++)
{
    if (hundreds.Count() > 0)
    {
        for(int j = 0; j < hundreds.Count()/2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = hundreds[j];
            lvi.SubItems.Add(hundreds[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            hundreds.RemoveAt(j);
            hundreds.RemoveAt(j);
            j++;
        }
    }
    if (nineties.Count() > 0)
    {
        for (int j = 0; j < nineties.Count()/2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = nineties[j];
            lvi.SubItems.Add(nineties[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            nineties.RemoveAt(j);
            nineties.RemoveAt(j);
            j++;
        }
    }
    if (eighties.Count() > 0)
    {
        for (int j = 0; j < eighties.Count()/2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = eighties[j];
            lvi.SubItems.Add(eighties[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            eighties.RemoveAt(j);
            eighties.RemoveAt(j);
            j++;
        }
    }
    if (seventies.Count() > 0)
    {
        for (int j = 0; j < seventies.Count()/2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = seventies[j];
            lvi.SubItems.Add(seventies[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            seventies.RemoveAt(j);
            seventies.RemoveAt(j);
            j++;
        }
    }
    if (sixties.Count() > 0)
    {
        for (int j = 0; j < sixties.Count()/2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = sixties[j];
            lvi.SubItems.Add(sixties[j+1].ToString());
            listViewRanking.Items.Add(lvi);
            sixties.RemoveAt(j);
            sixties.RemoveAt(j);
            j++;
        }
    }
    if (fifties.Count() > 0)
    {
        for (int j = 0; j < fifties.Count() / 2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = fifties[j];
            lvi.SubItems.Add(fifties[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            fifties.RemoveAt(j);
            fifties.RemoveAt(j);
            j++;
        }
    }
    if (fourties.Count() > 0)
    {
        for (int j = 0; j < fourties.Count() / 2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = fourties[j];
            lvi.SubItems.Add(fourties[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            fourties.RemoveAt(j);
            fourties.RemoveAt(j);
            j++;
        }
    }
    if (thirties.Count() > 0)
    {
        for (int j = 0; j < thirties.Count() / 2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = thirties[j];
            lvi.SubItems.Add(thirties[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            thirties.RemoveAt(j);
            thirties.RemoveAt(j);
            j++;
        }
    }
    if (twenties.Count() > 0)
    {
        for (int j = 0; j < twenties.Count() / 2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = twenties[j];
            lvi.SubItems.Add(twenties[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            twenties.RemoveAt(j);
            twenties.RemoveAt(j);
            j++;
        }
    }
    if (tens.Count() > 0)
    {
        for (int j = 0; j < tens.Count() / 2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = tens[j];
            lvi.SubItems.Add(tens[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            tens.RemoveAt(j);
            tens.RemoveAt(j);
            j++;
        }
    }
    if (zeros.Count() > 0)
    {
        for (int j = 0; j < zeros.Count() / 2; j++)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Selected = false;
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = zeros[j];
            lvi.SubItems.Add(zeros[j + 1].ToString());
            listViewRanking.Items.Add(lvi);
            zeros.RemoveAt(j);
            zeros.RemoveAt(j);
            j++;
        }
    }
}


ListViewItem lvi = new ListViewItem();
lvi.Selected = false;
lvi.UseItemStyleForSubItems = false;
lvi.Text = users[i];
lvi.SubItems.Add(score.ToString());
listViewRanking.Items.Add(lvi);



ListViewItem lvi = new ListViewItem();
for (int i = 0; i < users.Count(); i++)
{

}
MessageBox.Show(@".\Data");
MessageBox.Show(String.Join(", ", users));
*/

