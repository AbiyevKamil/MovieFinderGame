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
using System.Text.RegularExpressions;

namespace MovieFinderGame
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '•';
            textBoxPasswordAgain.PasswordChar = '•';
        }

        private void labelHaveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string regexSturct = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regexMail = new Regex(regexSturct);
            string username = textBoxUsername.Text.Trim();
            string mail = textBoxMail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string passwordAgain = textBoxPasswordAgain.Text.Trim();
            if (username != "" && mail != "" && password != "" && passwordAgain != "")
            {
                if (regexMail.IsMatch(mail))
                {
                    if (username.Contains(" ") || username.Contains("#") || username.Contains("<") || username.Contains("$") || username.Contains("+") || username.Contains("%") || username.Contains(">") || username.Contains("`") || username.Contains("!") || username.Contains("&") || username.Contains("*") || username.Contains("'") || username.Contains("|") || username.Contains("{") || username.Contains("}") || username.Contains("?") || username.Contains("\"") || username.Contains("=") || username.Contains("/") || username.Contains(":") || username.Contains("@"))
                    {
                        MessageBox.Show("Username can`t contain any of the following characters:\n! \" ' / ! ? < > # $ + % ! *", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (password == passwordAgain)
                        {
                            string path = @"Data\" + username;
                            string dataFilePath = path + @"\data.dll";

                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                                FileStream dataFile = File.Create(dataFilePath);
                                StreamWriter swDataFile = new StreamWriter(dataFile);
                                swDataFile.WriteLine(username);
                                swDataFile.WriteLine(mail);
                                swDataFile.WriteLine(password);

                                Login loginPage = new Login();
                                loginPage.Show();
                                this.Hide();

                                // Terminate files
                                swDataFile.Close();
                                dataFile.Close();
                            }
                            else
                            {
                                MessageBox.Show("Username already exists!", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords doesn`t match!", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("E-mail is not valid!", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (username == "" || mail == "" || password == "" || passwordAgain == "")
            {
                MessageBox.Show("Fill the form!", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPasswordAgain.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxPasswordAgain.PasswordChar = '•';
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
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