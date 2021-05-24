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

namespace MovieFinderGame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '•';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string mail = textBoxMail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string path = @"Data\" + username;
            string dataFilePath = path + @"\data.dll";
            if (username != "" && password != "" && mail != "")
            {
                if (Directory.Exists(path))
                {
                    StreamReader srForPassword = new StreamReader(dataFilePath);
                    srForPassword.ReadLine();
                    string mailSaved = srForPassword.ReadLine().Trim();
                    string passwordSaved = srForPassword.ReadLine().Trim();
                    srForPassword.Close();
                    if (passwordSaved == password && mailSaved == mail)
                    {
                        buttonGoBack.Visible = false;
                        timerLoading.Start();
                        cpbLoading.Show();
                        cpbLoading.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Wrong information!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong information!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill the form!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                // \0 refers to a null character
                // '\u0000' means null character in Unicode and it does the same thing as '\0'
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
            }
        }

        private void labelHaveNoAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerPage = new Register();
            registerPage.Show();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            panelLoading.BringToFront();
            cpbLoading.BringToFront();
            if (cpbLoading.Value < 100)
                cpbLoading.Value += 1;
            else
            {
                timerLoading.Stop();
                Game game = new Game(textBoxUsername.Text);
                game.Show();
                this.Hide();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main();
            this.Hide();
            mainPage.Show();
        }
    }
}
