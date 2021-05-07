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
using System.IO;

namespace MovieFInderApp
{
    public partial class Game : Form
    {
        string PPPath;
        public int liveScore = 0;
        string trueAnswer;
        public bool isGameStarted = false;
        public bool isJokerUsed = false;
        public bool isAnswered = false;
        public bool isAnswerTrue = false;
        public string movieVideoPathForReplay;
        public int generatedMoviesCount;
        public string username;
        public static string[] movies = {
            "AvengersEndGame", "Deadshot", "HIMYM", "Interstellar", "Lost",
            "Sherlock", "TenetMeetScene", "TenetReversedBullet", "TheAvengers",
            "TheTrumanShow"
        };
        List<int> tempList = new List<int>();
        List<string> moviesList = new List<string>(movies);

        public Game(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            disableJoker();
            generatedMoviesCount = 0;
            unvisibleNextButton();
            unvisibleButtons();
            wmpMoviePlayer.Ctlenabled = false;
            panelProfilePhoto.BackgroundImageLayout = ImageLayout.Stretch;
            labelUsername.Text = "Username: " + username;
            if (!username.Contains("Guest"))
            {
                StreamReader readData = new StreamReader(@"Data\" + username + @"\data.dll");
                readData.ReadLine();
                readData.ReadLine();
                readData.ReadLine();
                string pathPhoto = readData.ReadLine();
                readData.Close();
                if (File.Exists(pathPhoto))
                {
                    Image profilPhoto = new Bitmap(pathPhoto);
                    panelProfilePhoto.BackgroundImage = profilPhoto;
                }
                string scorePath = @"Data\" + username + @"\scores.dll";
                if (File.Exists(scorePath))
                {
                    StreamReader scoreReader = new StreamReader(scorePath);
                    int lastScore = int.Parse(scoreReader.ReadLine());
                    labelHighScore.Text = "Your high score: " + lastScore;
                    scoreReader.Close();
                }
                else
                {
                    labelHighScore.Text = "Your high score: 0";
                }
            }
            else
            {
                labelHighScore.Text = "Your high score: 0";
            }
            buttonPlayAgain.Enabled = false;
        }
        public System.Drawing.Imaging.ImageFormat GetImageFormat(System.Drawing.Image img)
        {
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                return System.Drawing.Imaging.ImageFormat.Bmp;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return System.Drawing.Imaging.ImageFormat.Png;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
                return System.Drawing.Imaging.ImageFormat.Emf;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
                return System.Drawing.Imaging.ImageFormat.Exif;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                return System.Drawing.Imaging.ImageFormat.Gif;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
                return System.Drawing.Imaging.ImageFormat.Icon;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
                return System.Drawing.Imaging.ImageFormat.MemoryBmp;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
                return System.Drawing.Imaging.ImageFormat.Tiff;
            else
                return System.Drawing.Imaging.ImageFormat.Wmf;
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            if (!username.Contains("Guest"))
            {
                OpenFileDialog choosePP = new OpenFileDialog();
                choosePP.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                DialogResult choosePPResult = choosePP.ShowDialog();
                if (choosePPResult == DialogResult.OK)
                {
                    try
                    {
                        string ppFileLocation = choosePP.FileName;
                        Image fileLocation = new Bitmap(ppFileLocation);
                        string savePPPath = @"Data\" + username + @"\" + "pp." + GetImageFormat(fileLocation).ToString().ToLower();
                        if (!File.Exists(savePPPath))
                        {
                            PPPath = savePPPath;
                            fileLocation.Save(savePPPath);
                            using (StreamWriter writePPPathtoFile = new StreamWriter(@"Data\" + username + @"\data.dll", append: true))
                            {
                                writePPPathtoFile.WriteLine(savePPPath);
                            };


                            panelProfilePhoto.BackgroundImage = fileLocation;
                            panelProfilePhoto.BackgroundImageLayout = ImageLayout.Stretch;

                        }
                        else
                        {
                            MessageBox.Show("You already have a profile photo and can`t change it!", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occured. Please, use another image.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("You can't add or remove profile photo while playing as a guest!", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonRemovePhoto_Click(object sender, EventArgs e)
        {
            if (!username.Contains("Guest"))
            {
                StreamReader readData = new StreamReader(@"Data\" + username + @"\data.dll");
                readData.ReadLine();
                readData.ReadLine();
                readData.ReadLine();
                string pathPhoto = readData.ReadLine();
                readData.Close();
                if (File.Exists(pathPhoto))
                {
                    PPPath = pathPhoto;
                    panelProfilePhoto.BackgroundImage = null;
                    File.Delete(PPPath);
                }
                else
                {
                    MessageBox.Show("You don`t have a profile photo.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("You can't add or remove profile photo while playing as a guest!", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            isGameStarted = true;
            MessageBox.Show("Game will start after 3 seconds.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timerStartGame.Start();
            generatedMoviesCount = 0;
            liveScore = 0;
            tempList.Clear();
            isJokerUsed = false;
            wmpMoviePlayer.Ctlcontrols.stop();
            disableButtons();
            unvisibleButtons();
            unvisibleNextButton();
        }

        private int generateIndex()
        {
            Random randomIndexGenerator = new Random();
            int index;
            int indexTest = randomIndexGenerator.Next(0, 10);

            if (!tempList.Contains(indexTest))
            {
                index = indexTest;
                tempList.Add(index);
                return index;
            }
            try
            {
                return generateIndex();
            }
            catch (Exception)
            {
                return 0;
            }

        }

        private void StartGame()
        {
            buttonPlayAgain.Enabled = true;
            isJokerUsed = false;
            wmpMoviePlayer.Ctlcontrols.stop();
            int indexMovie = 0;
            if (generatedMoviesCount < 5)
            {
                indexMovie = generateIndex();
            }
            generatedMoviesCount++;
            string movieVideoFilePath = @"Movies\" + moviesList[indexMovie] + @"\movie.mp4";
            string movieAnswersFilePath = @"Movies\" + moviesList[indexMovie] + @"\answers.txt";
            wmpMoviePlayer.URL = movieVideoFilePath;
            movieVideoPathForReplay = movieVideoFilePath;
            wmpMoviePlayer.Ctlcontrols.play();

            StreamReader readAnswers = new StreamReader(movieAnswersFilePath);
            string a = readAnswers.ReadLine();
            string b = readAnswers.ReadLine();
            string c = readAnswers.ReadLine();
            string d = readAnswers.ReadLine();
            string answer = readAnswers.ReadLine();
            setButtonAText(a);
            setButtonBText(b);
            setButtonCText(c);
            setButtonDText(d);
            setTrueAnswer(answer);
            enableButtons();
            visibleButtons();
            if (isJokerUsed)
            {
                disableJoker();
            }
        }

        private void timerStartGame_Tick(object sender, EventArgs e)
        {
            timerStartGame.Stop();
            enableJoker();
            StartGame();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            wmpMoviePlayer.Ctlcontrols.stop();
            wmpMoviePlayer.URL = movieVideoPathForReplay;
            wmpMoviePlayer.Ctlcontrols.play();
        }


        private void disableJoker()
        {
            buttonFiftyFifty.Enabled = false;
        }

        private void enableJoker()
        {
            buttonFiftyFifty.Enabled = true;
        }

        private void unvisibleNextButton()
        {
            buttonNext.Visible = false;
        }

        private void visibleNextButton()
        {
            buttonNext.Visible = true;
        }


        private void disableButtons()
        {

            buttonAnswerA.Enabled = false;
            buttonAnswerB.Enabled = false;
            buttonAnswerC.Enabled = false;
            buttonAnswerD.Enabled = false;
        }

        private void enableButtons()
        {
            buttonAnswerA.Enabled = true;
            buttonAnswerB.Enabled = true;
            buttonAnswerC.Enabled = true;
            buttonAnswerD.Enabled = true;
        }

        private void unvisibleButtons()
        {
            buttonAnswerA.Visible = false;
            buttonAnswerB.Visible = false;
            buttonAnswerC.Visible = false;
            buttonAnswerD.Visible = false;
        }

        private void visibleButtons()
        {
            buttonAnswerA.Visible = true;
            buttonAnswerB.Visible = true;
            buttonAnswerC.Visible = true;
            buttonAnswerD.Visible = true;
        }

        private void setTrueAnswer(string trueAnswer)
        {
            this.trueAnswer = trueAnswer;
        }

        private void setButtonAText(string answer)
        {
            buttonAnswerA.Text = answer;
        }

        private void setButtonBText(string answer)
        {
            buttonAnswerB.Text = answer;
        }

        private void setButtonCText(string answer)
        {
            buttonAnswerC.Text = answer;
        }

        private void setButtonDText(string answer)
        {
            buttonAnswerD.Text = answer;
        }

        private void stopGame()
        {
            wmpMoviePlayer.Ctlcontrols.stop();
            buttonPlayAgain.Enabled = false;
            isGameStarted = false;
            unvisibleButtons();
            disableButtons();
            unvisibleNextButton();
            disableJoker();
            generatedMoviesCount = 0;
            liveScore = 0;
            tempList.Clear();
        }

        private void buttonAnswerA_Click(object sender, EventArgs e)
        {
            if (buttonAnswerA.Text == trueAnswer)
            {
                if (isJokerUsed)
                {
                    MessageBox.Show("True");
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MessageBox.Show("False");
            }
            disableButtons();
            visibleNextButton();

        }

        private void buttonAnswerB_Click(object sender, EventArgs e)
        {
            if (buttonAnswerB.Text == trueAnswer)
            {
                if (isJokerUsed)
                {
                    MessageBox.Show("True");
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MessageBox.Show("False");
            }
            disableButtons();
            visibleNextButton();

        }

        private void buttonAnswerC_Click(object sender, EventArgs e)
        {
            if (buttonAnswerC.Text == trueAnswer)
            {
                if (isJokerUsed)
                {
                    MessageBox.Show("True");
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MessageBox.Show("False");
            }
            disableButtons();
            visibleNextButton();

        }

        private void buttonAnswerD_Click(object sender, EventArgs e)
        {
            if (buttonAnswerD.Text == trueAnswer)
            {
                if (isJokerUsed)
                {
                    MessageBox.Show("True");
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MessageBox.Show("False");
            }
            disableButtons();
            visibleNextButton();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int lastScore = 0;
            labelScore.Text = liveScore.ToString();
            if (generatedMoviesCount < 5)
                labelQuestionNumberNow.Text = (generatedMoviesCount + 1).ToString() + "/5";
            if (generatedMoviesCount < 5)
                StartGame();
            else
            {
                wmpMoviePlayer.Ctlcontrols.stop();
                disableButtons();
                unvisibleButtons();
                unvisibleNextButton();
                disableJoker();
                buttonPlayAgain.Enabled = false;
                isGameStarted = false;
                if (!username.Contains("Guest"))
                {
                    string scorePath = @"Data\" + username + @"\scores.dll";
                    if (File.Exists(scorePath))
                    {
                        StreamReader scoreReader = new StreamReader(scorePath);
                        lastScore = int.Parse(scoreReader.ReadLine());
                        scoreReader.Close();
                    }
                    if (lastScore < liveScore)
                    {
                        File.Delete(scorePath);
                        StreamWriter scoreSaver = new StreamWriter(scorePath);
                        scoreSaver.WriteLine(liveScore);
                        scoreSaver.Close();
                    }
                }
                CongratsForm congratsForm = new CongratsForm(username, lastScore);
                congratsForm.ShowDialog();
            }
        }

        public Button checkTrueButton()
        {
            if (buttonAnswerA.Text == trueAnswer)
                return buttonAnswerA;
            else if (buttonAnswerB.Text == trueAnswer)
                return buttonAnswerB;
            else if (buttonAnswerC.Text == trueAnswer)
                return buttonAnswerC;
            else
                return buttonAnswerD;
        }

        private void buttonFiftyFifty_Click(object sender, EventArgs e)
        {
            isJokerUsed = true;
            Button trueButton = checkTrueButton();
            Button secondButton = trueButton;
            Button[] buttons = { buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD };
            for (int i = 0; i < buttons.Count(); i++)
            {
                if (buttons[i] != trueButton)
                {
                    secondButton = buttons[i];
                    break;
                }
            }
            for (int i = 0; i < buttons.Count(); i++)
            {
                if (buttons[i] != trueButton)
                    if (buttons[i] != secondButton)
                        buttons[i].Visible = false;
            }
            disableJoker();
        }

        private void buttonStopGame_Click(object sender, EventArgs e)
        {
            if (isGameStarted)
            {
                stopGame();
                isGameStarted = false;
            }
            else MessageBox.Show("No game to stop.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            if (isGameStarted)
            {
                MessageBox.Show("Game will start after 3 seconds.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerStartGame.Start();
                generatedMoviesCount = 0;
                liveScore = 0;
                tempList.Clear();
                isJokerUsed = false;
                wmpMoviePlayer.Ctlcontrols.stop();
                disableButtons();
                unvisibleButtons();
                unvisibleNextButton();
                disableJoker();
                buttonPlayAgain.Enabled = false;
            }
            else
            {
                MessageBox.Show("You haven't started a game", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            stopGame();
            this.Hide();
            Main mainPage = new Main();
            mainPage.Show();
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            stopGame();
            Ranking rankingPage = new Ranking();
            rankingPage.ShowDialog();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("");
            if (e.KeyCode == Keys.F1)
            {
                InformationBox informationBox = new InformationBox();
                informationBox.ShowDialog();
            }
        }
    }
}
