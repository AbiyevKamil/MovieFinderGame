
namespace MovieFInderApp
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.buttonStopGame = new System.Windows.Forms.Button();
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.panelPP = new System.Windows.Forms.Panel();
            this.panelProfilePhoto = new System.Windows.Forms.Panel();
            this.labelQuestionNumberNow = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelYourScore = new System.Windows.Forms.Label();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.buttonFiftyFifty = new System.Windows.Forms.Button();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.panelHideControls = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.wmpMoviePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerStartGame = new System.Windows.Forms.Timer(this.components);
            this.buttonAnswerA = new System.Windows.Forms.Button();
            this.buttonAnswerB = new System.Windows.Forms.Button();
            this.buttonAnswerC = new System.Windows.Forms.Button();
            this.buttonAnswerD = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelGameArea.SuspendLayout();
            this.panelPP.SuspendLayout();
            this.groupBoxHelp.SuspendLayout();
            this.panelHideControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMoviePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartGame.FlatAppearance.BorderSize = 0;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.Color.White;
            this.buttonStartGame.Location = new System.Drawing.Point(41, 181);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(150, 68);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPhoto.FlatAppearance.BorderSize = 0;
            this.buttonAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPhoto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPhoto.ForeColor = System.Drawing.Color.White;
            this.buttonAddPhoto.Location = new System.Drawing.Point(20, 36);
            this.buttonAddPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(107, 35);
            this.buttonAddPhoto.TabIndex = 2;
            this.buttonAddPhoto.Text = "Add Photo";
            this.buttonAddPhoto.UseVisualStyleBackColor = false;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // labelHighScore
            // 
            this.labelHighScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelHighScore.Location = new System.Drawing.Point(19, 60);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(163, 27);
            this.labelHighScore.TabIndex = 2;
            this.labelHighScore.Text = "Your High Score: ";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelUsername.Location = new System.Drawing.Point(19, 23);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(103, 27);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // buttonRanking
            // 
            this.buttonRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRanking.FlatAppearance.BorderSize = 0;
            this.buttonRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRanking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRanking.ForeColor = System.Drawing.Color.White;
            this.buttonRanking.Location = new System.Drawing.Point(41, 462);
            this.buttonRanking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Size = new System.Drawing.Size(150, 68);
            this.buttonRanking.TabIndex = 2;
            this.buttonRanking.Text = "Ranking";
            this.buttonRanking.UseVisualStyleBackColor = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.panelUsername);
            this.panelLeft.Controls.Add(this.panelInfo);
            this.panelLeft.Controls.Add(this.buttonResetGame);
            this.panelLeft.Controls.Add(this.buttonStopGame);
            this.panelLeft.Controls.Add(this.buttonRanking);
            this.panelLeft.Controls.Add(this.buttonStartGame);
            this.panelLeft.Location = new System.Drawing.Point(0, -1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(233, 688);
            this.panelLeft.TabIndex = 3;
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.labelUsername);
            this.panelUsername.Controls.Add(this.labelHighScore);
            this.panelUsername.Location = new System.Drawing.Point(0, 0);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(233, 112);
            this.panelUsername.TabIndex = 5;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Location = new System.Drawing.Point(0, 609);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(230, 76);
            this.panelInfo.TabIndex = 4;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelInfo.Location = new System.Drawing.Point(7, 24);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(220, 27);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Press F1 for information";
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetGame.FlatAppearance.BorderSize = 0;
            this.buttonResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetGame.ForeColor = System.Drawing.Color.White;
            this.buttonResetGame.Location = new System.Drawing.Point(41, 369);
            this.buttonResetGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(150, 68);
            this.buttonResetGame.TabIndex = 5;
            this.buttonResetGame.Text = "Reset Game";
            this.buttonResetGame.UseVisualStyleBackColor = false;
            // 
            // buttonStopGame
            // 
            this.buttonStopGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonStopGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopGame.FlatAppearance.BorderSize = 0;
            this.buttonStopGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopGame.ForeColor = System.Drawing.Color.White;
            this.buttonStopGame.Location = new System.Drawing.Point(41, 274);
            this.buttonStopGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStopGame.Name = "buttonStopGame";
            this.buttonStopGame.Size = new System.Drawing.Size(150, 68);
            this.buttonStopGame.TabIndex = 4;
            this.buttonStopGame.Text = "Stop Game";
            this.buttonStopGame.UseVisualStyleBackColor = false;
            // 
            // panelGameArea
            // 
            this.panelGameArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGameArea.BackColor = System.Drawing.Color.Transparent;
            this.panelGameArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGameArea.BackgroundImage")));
            this.panelGameArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameArea.Controls.Add(this.buttonNext);
            this.panelGameArea.Controls.Add(this.buttonAnswerD);
            this.panelGameArea.Controls.Add(this.buttonAnswerC);
            this.panelGameArea.Controls.Add(this.buttonAnswerB);
            this.panelGameArea.Controls.Add(this.buttonAnswerA);
            this.panelGameArea.Controls.Add(this.panelPP);
            this.panelGameArea.Controls.Add(this.labelQuestionNumberNow);
            this.panelGameArea.Controls.Add(this.labelScore);
            this.panelGameArea.Controls.Add(this.labelYourScore);
            this.panelGameArea.Controls.Add(this.labelQuestionNumber);
            this.panelGameArea.Controls.Add(this.groupBoxHelp);
            this.panelGameArea.Controls.Add(this.panelHideControls);
            this.panelGameArea.Controls.Add(this.wmpMoviePlayer);
            this.panelGameArea.Location = new System.Drawing.Point(230, -1);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(1140, 688);
            this.panelGameArea.TabIndex = 4;
            // 
            // panelPP
            // 
            this.panelPP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPP.BackColor = System.Drawing.Color.Transparent;
            this.panelPP.Controls.Add(this.panelProfilePhoto);
            this.panelPP.Controls.Add(this.buttonAddPhoto);
            this.panelPP.Location = new System.Drawing.Point(914, 0);
            this.panelPP.Name = "panelPP";
            this.panelPP.Size = new System.Drawing.Size(224, 99);
            this.panelPP.TabIndex = 5;
            // 
            // panelProfilePhoto
            // 
            this.panelProfilePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfilePhoto.BackColor = System.Drawing.Color.Silver;
            this.panelProfilePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProfilePhoto.Location = new System.Drawing.Point(134, 23);
            this.panelProfilePhoto.Name = "panelProfilePhoto";
            this.panelProfilePhoto.Size = new System.Drawing.Size(71, 59);
            this.panelProfilePhoto.TabIndex = 3;
            // 
            // labelQuestionNumberNow
            // 
            this.labelQuestionNumberNow.AutoSize = true;
            this.labelQuestionNumberNow.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionNumberNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumberNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelQuestionNumberNow.Location = new System.Drawing.Point(107, 20);
            this.labelQuestionNumberNow.Name = "labelQuestionNumberNow";
            this.labelQuestionNumberNow.Size = new System.Drawing.Size(45, 28);
            this.labelQuestionNumberNow.TabIndex = 8;
            this.labelQuestionNumberNow.Text = "1/5";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelScore.Location = new System.Drawing.Point(132, 73);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(24, 28);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "0";
            // 
            // labelYourScore
            // 
            this.labelYourScore.AutoSize = true;
            this.labelYourScore.BackColor = System.Drawing.Color.Transparent;
            this.labelYourScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelYourScore.Location = new System.Drawing.Point(15, 73);
            this.labelYourScore.Name = "labelYourScore";
            this.labelYourScore.Size = new System.Drawing.Size(121, 28);
            this.labelYourScore.TabIndex = 6;
            this.labelYourScore.Text = "Your score: ";
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelQuestionNumber.Location = new System.Drawing.Point(15, 20);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(108, 28);
            this.labelQuestionNumber.TabIndex = 5;
            this.labelQuestionNumber.Text = "Question: ";
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHelp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxHelp.Controls.Add(this.buttonFiftyFifty);
            this.groupBoxHelp.Controls.Add(this.buttonPlayAgain);
            this.groupBoxHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxHelp.Location = new System.Drawing.Point(913, 102);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(221, 171);
            this.groupBoxHelp.TabIndex = 4;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Help";
            // 
            // buttonFiftyFifty
            // 
            this.buttonFiftyFifty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFiftyFifty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonFiftyFifty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFiftyFifty.FlatAppearance.BorderSize = 0;
            this.buttonFiftyFifty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiftyFifty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiftyFifty.ForeColor = System.Drawing.Color.White;
            this.buttonFiftyFifty.Location = new System.Drawing.Point(55, 49);
            this.buttonFiftyFifty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFiftyFifty.Name = "buttonFiftyFifty";
            this.buttonFiftyFifty.Size = new System.Drawing.Size(129, 36);
            this.buttonFiftyFifty.TabIndex = 0;
            this.buttonFiftyFifty.Text = "50/50";
            this.buttonFiftyFifty.UseVisualStyleBackColor = false;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayAgain.FlatAppearance.BorderSize = 0;
            this.buttonPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayAgain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.ForeColor = System.Drawing.Color.White;
            this.buttonPlayAgain.Location = new System.Drawing.Point(55, 109);
            this.buttonPlayAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(129, 36);
            this.buttonPlayAgain.TabIndex = 2;
            this.buttonPlayAgain.Text = "Replay";
            this.buttonPlayAgain.UseVisualStyleBackColor = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // panelHideControls
            // 
            this.panelHideControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHideControls.BackColor = System.Drawing.Color.Black;
            this.panelHideControls.Controls.Add(this.labelQuestion);
            this.panelHideControls.Location = new System.Drawing.Point(283, 266);
            this.panelHideControls.Name = "panelHideControls";
            this.panelHideControls.Size = new System.Drawing.Size(542, 63);
            this.panelHideControls.TabIndex = 1;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelQuestion.Location = new System.Drawing.Point(185, 13);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(193, 28);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Which movie is that?";
            // 
            // wmpMoviePlayer
            // 
            this.wmpMoviePlayer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.wmpMoviePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpMoviePlayer.Enabled = true;
            this.wmpMoviePlayer.Location = new System.Drawing.Point(283, 0);
            this.wmpMoviePlayer.Name = "wmpMoviePlayer";
            this.wmpMoviePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMoviePlayer.OcxState")));
            this.wmpMoviePlayer.Size = new System.Drawing.Size(542, 329);
            this.wmpMoviePlayer.TabIndex = 0;
            this.wmpMoviePlayer.TabStop = false;
            // 
            // timerStartGame
            // 
            this.timerStartGame.Interval = 2000;
            this.timerStartGame.Tick += new System.EventHandler(this.timerStartGame_Tick);
            // 
            // buttonAnswerA
            // 
            this.buttonAnswerA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonAnswerA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnswerA.FlatAppearance.BorderSize = 0;
            this.buttonAnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnswerA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerA.ForeColor = System.Drawing.Color.White;
            this.buttonAnswerA.Location = new System.Drawing.Point(283, 346);
            this.buttonAnswerA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnswerA.Name = "buttonAnswerA";
            this.buttonAnswerA.Size = new System.Drawing.Size(542, 36);
            this.buttonAnswerA.TabIndex = 9;
            this.buttonAnswerA.Text = "Answer";
            this.buttonAnswerA.UseVisualStyleBackColor = false;
            this.buttonAnswerA.Visible = false;
            this.buttonAnswerA.Click += new System.EventHandler(this.buttonAnswerA_Click);
            // 
            // buttonAnswerB
            // 
            this.buttonAnswerB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonAnswerB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnswerB.FlatAppearance.BorderSize = 0;
            this.buttonAnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnswerB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerB.ForeColor = System.Drawing.Color.White;
            this.buttonAnswerB.Location = new System.Drawing.Point(283, 392);
            this.buttonAnswerB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnswerB.Name = "buttonAnswerB";
            this.buttonAnswerB.Size = new System.Drawing.Size(542, 36);
            this.buttonAnswerB.TabIndex = 10;
            this.buttonAnswerB.Text = "Answer";
            this.buttonAnswerB.UseVisualStyleBackColor = false;
            this.buttonAnswerB.Visible = false;
            this.buttonAnswerB.Click += new System.EventHandler(this.buttonAnswerB_Click);
            // 
            // buttonAnswerC
            // 
            this.buttonAnswerC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonAnswerC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnswerC.FlatAppearance.BorderSize = 0;
            this.buttonAnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnswerC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerC.ForeColor = System.Drawing.Color.White;
            this.buttonAnswerC.Location = new System.Drawing.Point(283, 438);
            this.buttonAnswerC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnswerC.Name = "buttonAnswerC";
            this.buttonAnswerC.Size = new System.Drawing.Size(542, 36);
            this.buttonAnswerC.TabIndex = 11;
            this.buttonAnswerC.Text = "Answer";
            this.buttonAnswerC.UseVisualStyleBackColor = false;
            this.buttonAnswerC.Visible = false;
            this.buttonAnswerC.Click += new System.EventHandler(this.buttonAnswerC_Click);
            // 
            // buttonAnswerD
            // 
            this.buttonAnswerD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonAnswerD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnswerD.FlatAppearance.BorderSize = 0;
            this.buttonAnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnswerD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerD.ForeColor = System.Drawing.Color.White;
            this.buttonAnswerD.Location = new System.Drawing.Point(283, 484);
            this.buttonAnswerD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnswerD.Name = "buttonAnswerD";
            this.buttonAnswerD.Size = new System.Drawing.Size(542, 36);
            this.buttonAnswerD.TabIndex = 12;
            this.buttonAnswerD.Text = "Answer";
            this.buttonAnswerD.UseVisualStyleBackColor = false;
            this.buttonAnswerD.Visible = false;
            this.buttonAnswerD.Click += new System.EventHandler(this.buttonAnswerD_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(829, 588);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(129, 36);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 686);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelGameArea);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Game";
            this.Text = "Answer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelGameArea.ResumeLayout(false);
            this.panelGameArea.PerformLayout();
            this.panelPP.ResumeLayout(false);
            this.groupBoxHelp.ResumeLayout(false);
            this.panelHideControls.ResumeLayout(false);
            this.panelHideControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMoviePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Button buttonRanking;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.Button buttonStopGame;
        private System.Windows.Forms.Panel panelGameArea;
        private AxWMPLib.AxWindowsMediaPlayer wmpMoviePlayer;
        private System.Windows.Forms.Panel panelHideControls;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.Button buttonFiftyFifty;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Label labelQuestionNumberNow;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelYourScore;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPP;
        private System.Windows.Forms.Panel panelProfilePhoto;
        private System.Windows.Forms.Timer timerStartGame;
        private System.Windows.Forms.Button buttonAnswerD;
        private System.Windows.Forms.Button buttonAnswerC;
        private System.Windows.Forms.Button buttonAnswerB;
        private System.Windows.Forms.Button buttonAnswerA;
        private System.Windows.Forms.Button buttonNext;
    }
}