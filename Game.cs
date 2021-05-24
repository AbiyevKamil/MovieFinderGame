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

namespace MovieFinderGame
{
    public partial class Game : Form
    {
        Random randomIndexGenerator = new Random();
        public int liveScore = 0;
        string trueAnswer;
        public bool isGameStarted = false;
        public bool isJokerUsed = false;
        public bool isAnswered = false;
        public bool isAnswerTrue = false;
        public string movieVideoPathForReplay;
        public int generatedMoviesCount;
        public string username;
        List<int> tempList = new List<int>();
        List<string> moviesList = new List<string>()
        {
            "AvengersEndGame", "Deadshot", "HIMYM", "Interstellar", "Lost",
            "Sherlock", "TenetMeetScene", "TenetReversedBullet", "TheAvengers",
            "TheTrumanShow"
        };

        List<int> lastScores = new List<int>();

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
            labelUsername.Text = "Username: " + username;
            if (!username.Contains("Guest"))
            {
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

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (!isGameStarted)
            {
                generatedMoviesCount = 0;
                liveScore = 0;
                tempList.Clear();
                isJokerUsed = false;
                wmpMoviePlayer.Ctlcontrols.stop();
                disableButtons();
                unvisibleButtons();
                unvisibleNextButton();
                timerStartGame.Start();
                isGameStarted = true;
            }
            else
            {
                MessageBox.Show("Game is already started.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int generateIndex()
        {
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
                MessageBox.Show("Error happened. Stop game and start again.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void StartGame()
        {
            buttonNext.Visible = true;
            makeButtonsReady();
            isGameStarted = true;
            buttonPlayAgain.Enabled = true;
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


        private void MakeButtonAGreen()
        {
            buttonAnswerA.BackColor = Color.Green;
        }

        private void MakeButtonBGreen()
        {
            buttonAnswerB.BackColor = Color.Green;
        }

        private void MakeButtonCGreen()
        {
            buttonAnswerC.BackColor = Color.Green;
        }

        private void MakeButtonDGreen()
        {
            buttonAnswerD.BackColor = Color.Green;
        }

        private void MakeButtonARed()
        {
            buttonAnswerA.BackColor = Color.Red;
        }

        private void MakeButtonBRed()
        {
            buttonAnswerB.BackColor = Color.Red;
        }

        private void MakeButtonCRed()
        {
            buttonAnswerC.BackColor = Color.Red;
        }

        private void MakeButtonDRed()
        {
            buttonAnswerD.BackColor = Color.Red;
        }

        private void makeButtonsReady()
        {
            buttonAnswerA.BackColor = Color.DarkSlateGray;
            buttonAnswerB.BackColor = Color.DarkSlateGray;
            buttonAnswerC.BackColor = Color.DarkSlateGray;
            buttonAnswerD.BackColor = Color.DarkSlateGray;

        }

        private void buttonAnswerA_Click(object sender, EventArgs e)
        {
            if (buttonAnswerA.Text == trueAnswer)
            {
                MakeButtonAGreen();
                if (isJokerUsed)
                {
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MakeButtonARed();
            }
            labelScore.Text = liveScore.ToString();
            disableJoker();
            disableButtons();
            visibleNextButton();

        }

        private void buttonAnswerB_Click(object sender, EventArgs e)
        {
            if (buttonAnswerB.Text == trueAnswer)
            {
                MakeButtonBGreen();
                if (isJokerUsed)
                {
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MakeButtonBRed();
            }
            labelScore.Text = liveScore.ToString();
            disableJoker();
            disableButtons();
            visibleNextButton();

        }

        private void buttonAnswerC_Click(object sender, EventArgs e)
        {
            if (buttonAnswerC.Text == trueAnswer)
            {
                MakeButtonCGreen();
                if (isJokerUsed)
                {
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MakeButtonCRed();
            }
            labelScore.Text = liveScore.ToString();
            disableJoker();
            disableButtons();
            visibleNextButton();

        }


        private void buttonAnswerD_Click(object sender, EventArgs e)
        {
            if (buttonAnswerD.Text == trueAnswer)
            {
                MakeButtonDGreen();
                if (isJokerUsed)
                {
                    liveScore += 10;
                }
                else liveScore += 20;
            }
            else
            {
                MakeButtonDRed();
            }
            labelScore.Text = liveScore.ToString();
            disableJoker();
            disableButtons();
            visibleNextButton();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            makeButtonsReady();
            if (!isJokerUsed)
            {
                enableJoker();
            }
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
                        if (lastScore < liveScore)
                        {
                            labelHighScore.Text = "Your high score: " + liveScore;
                            File.Delete(scorePath);
                            StreamWriter scoreSaver = new StreamWriter(scorePath);
                            scoreSaver.WriteLine(liveScore);
                            scoreSaver.Close();
                        }
                    }
                    else
                    {
                        StreamWriter scoreSaver = new StreamWriter(scorePath);
                        scoreSaver.WriteLine(liveScore);
                        scoreSaver.Close();
                        lastScores.Add(liveScore);
                        int max = -100;
                        if (lastScores.Count() > 0)
                        {
                            foreach (int score in lastScores)
                            {
                                if (score > max)
                                {
                                    max = score;
                                }
                            }
                            if (max < liveScore)
                            {
                                labelHighScore.Text = "Your high score: " + liveScore;
                            }
                            else
                            {
                                labelHighScore.Text = "Your high score: " + max;
                            }
                        }
                    }
                }
                else
                {
                    lastScores.Add(liveScore);
                    int max = -100;
                    if (lastScores.Count() > 0)
                    {
                        foreach (int score in lastScores)
                        {
                            if (score > max)
                            {
                                max = score;
                            }
                        }
                        if (max < liveScore)
                        {
                            labelHighScore.Text = "Your high score: " + liveScore;
                        }
                        else
                        {
                            labelHighScore.Text = "Your high score: " + max;
                        }
                    }

                }

                CongratsForm congratsForm = new CongratsForm(username, liveScore);
                congratsForm.ShowDialog();
                labelQuestionNumberNow.Text = "1" + "/5";
                labelScore.Text = "0";
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
                tempList.Clear();
            }
            else MessageBox.Show("You haven't started a game.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            if (isGameStarted)
            {
                makeButtonsReady();
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
                MessageBox.Show("You haven't started a game.", "Movie Finder Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            stopGame();
            this.Hide();
            Main mainPage = new Main();
            mainPage.Show();
            lastScores.Clear();
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            stopGame();
            Ranking rankingPage = new Ranking();
            rankingPage.ShowDialog();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                InformationBox informationBox = new InformationBox();
                informationBox.ShowDialog();
            }
        }

    }
}
