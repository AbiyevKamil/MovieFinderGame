
namespace MovieFInderApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLeftImg = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelRightContainer = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelHaveNoAccount = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelContainerPassword = new System.Windows.Forms.Panel();
            this.panelMail = new System.Windows.Forms.Panel();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.panelContainerEmail = new System.Windows.Forms.Panel();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelContainerUsername = new System.Windows.Forms.Panel();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.cpbLoading = new CircularProgressBar.CircularProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.panelRightContainer.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelMail.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftImg
            // 
            this.panelLeftImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeftImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeftImg.BackgroundImage")));
            this.panelLeftImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeftImg.Location = new System.Drawing.Point(-2, 1);
            this.panelLeftImg.Name = "panelLeftImg";
            this.panelLeftImg.Size = new System.Drawing.Size(663, 563);
            this.panelLeftImg.TabIndex = 19;
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelHeader.Location = new System.Drawing.Point(307, 18);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(133, 54);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Login";
            // 
            // panelRightContainer
            // 
            this.panelRightContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightContainer.BackColor = System.Drawing.Color.Silver;
            this.panelRightContainer.Controls.Add(this.labelHeader);
            this.panelRightContainer.Controls.Add(this.panelForm);
            this.panelRightContainer.Controls.Add(this.panelLoading);
            this.panelRightContainer.Location = new System.Drawing.Point(659, 1);
            this.panelRightContainer.Name = "panelRightContainer";
            this.panelRightContainer.Size = new System.Drawing.Size(720, 563);
            this.panelRightContainer.TabIndex = 20;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.Color.Silver;
            this.panelForm.Controls.Add(this.labelHaveNoAccount);
            this.panelForm.Controls.Add(this.checkBoxShowPassword);
            this.panelForm.Controls.Add(this.buttonLogin);
            this.panelForm.Controls.Add(this.panelPassword);
            this.panelForm.Controls.Add(this.panelMail);
            this.panelForm.Controls.Add(this.panelUsername);
            this.panelForm.Location = new System.Drawing.Point(40, 116);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(623, 410);
            this.panelForm.TabIndex = 0;
            // 
            // labelHaveNoAccount
            // 
            this.labelHaveNoAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelHaveNoAccount.AutoSize = true;
            this.labelHaveNoAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.labelHaveNoAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHaveNoAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaveNoAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHaveNoAccount.Location = new System.Drawing.Point(327, 271);
            this.labelHaveNoAccount.Name = "labelHaveNoAccount";
            this.labelHaveNoAccount.Padding = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.labelHaveNoAccount.Size = new System.Drawing.Size(260, 35);
            this.labelHaveNoAccount.TabIndex = 13;
            this.labelHaveNoAccount.Text = "Don`t you have an account?";
            this.labelHaveNoAccount.Click += new System.EventHandler(this.labelHaveNoAccount_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(34, 266);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Padding = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.checkBoxShowPassword.Size = new System.Drawing.Size(182, 40);
            this.checkBoxShowPassword.TabIndex = 12;
            this.checkBoxShowPassword.Text = "Show password";
            this.checkBoxShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxShowPassword.UseVisualStyleBackColor = false;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(191, 328);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(195, 63);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Controls.Add(this.labelPassword);
            this.panelPassword.Controls.Add(this.panelContainerPassword);
            this.panelPassword.Location = new System.Drawing.Point(35, 189);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(552, 53);
            this.panelPassword.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.textBoxPassword.Location = new System.Drawing.Point(156, 11);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(378, 31);
            this.textBoxPassword.TabIndex = 10;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Transparent;
            this.labelPassword.Location = new System.Drawing.Point(3, 9);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(117, 32);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // panelContainerPassword
            // 
            this.panelContainerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainerPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContainerPassword.Location = new System.Drawing.Point(137, 0);
            this.panelContainerPassword.Name = "panelContainerPassword";
            this.panelContainerPassword.Size = new System.Drawing.Size(415, 57);
            this.panelContainerPassword.TabIndex = 15;
            // 
            // panelMail
            // 
            this.panelMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelMail.Controls.Add(this.textBoxMail);
            this.panelMail.Controls.Add(this.labelMail);
            this.panelMail.Controls.Add(this.panelContainerEmail);
            this.panelMail.Location = new System.Drawing.Point(35, 118);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(552, 51);
            this.panelMail.TabIndex = 8;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.textBoxMail.Location = new System.Drawing.Point(156, 9);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(378, 31);
            this.textBoxMail.TabIndex = 10;
            // 
            // labelMail
            // 
            this.labelMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMail.Location = new System.Drawing.Point(3, 8);
            this.labelMail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(87, 32);
            this.labelMail.TabIndex = 1;
            this.labelMail.Text = "E-mail:";
            // 
            // panelContainerEmail
            // 
            this.panelContainerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainerEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContainerEmail.Location = new System.Drawing.Point(137, -1);
            this.panelContainerEmail.Name = "panelContainerEmail";
            this.panelContainerEmail.Size = new System.Drawing.Size(415, 57);
            this.panelContainerEmail.TabIndex = 15;
            // 
            // panelUsername
            // 
            this.panelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelUsername.Controls.Add(this.textBoxUsername);
            this.panelUsername.Controls.Add(this.labelUsername);
            this.panelUsername.Controls.Add(this.panelContainerUsername);
            this.panelUsername.Location = new System.Drawing.Point(35, 35);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(552, 57);
            this.panelUsername.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.textBoxUsername.Location = new System.Drawing.Point(156, 10);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(378, 31);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(3, 11);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(127, 32);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // panelContainerUsername
            // 
            this.panelContainerUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainerUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContainerUsername.Location = new System.Drawing.Point(137, 0);
            this.panelContainerUsername.Name = "panelContainerUsername";
            this.panelContainerUsername.Size = new System.Drawing.Size(415, 57);
            this.panelContainerUsername.TabIndex = 14;
            // 
            // panelLoading
            // 
            this.panelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoading.Controls.Add(this.buttonGoBack);
            this.panelLoading.Controls.Add(this.cpbLoading);
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(717, 563);
            this.panelLoading.TabIndex = 0;
            // 
            // cpbLoading
            // 
            this.cpbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpbLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbLoading.AnimationSpeed = 50;
            this.cpbLoading.BackColor = System.Drawing.Color.Transparent;
            this.cpbLoading.Enabled = false;
            this.cpbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbLoading.ForeColor = System.Drawing.Color.Transparent;
            this.cpbLoading.InnerColor = System.Drawing.Color.Transparent;
            this.cpbLoading.InnerMargin = 2;
            this.cpbLoading.InnerWidth = -1;
            this.cpbLoading.Location = new System.Drawing.Point(213, 91);
            this.cpbLoading.MarqueeAnimationSpeed = 50;
            this.cpbLoading.Name = "cpbLoading";
            this.cpbLoading.OuterColor = System.Drawing.Color.Gray;
            this.cpbLoading.OuterMargin = -25;
            this.cpbLoading.OuterWidth = 26;
            this.cpbLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpbLoading.ProgressWidth = 25;
            this.cpbLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbLoading.Size = new System.Drawing.Size(320, 320);
            this.cpbLoading.StartAngle = 270;
            this.cpbLoading.SubscriptColor = System.Drawing.Color.Transparent;
            this.cpbLoading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbLoading.SubscriptText = ".23";
            this.cpbLoading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbLoading.SuperscriptText = "";
            this.cpbLoading.TabIndex = 14;
            this.cpbLoading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbLoading.Value = 68;
            this.cpbLoading.Visible = false;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 50;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.buttonGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoBack.FlatAppearance.BorderSize = 0;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.ForeColor = System.Drawing.Color.White;
            this.buttonGoBack.Location = new System.Drawing.Point(534, 36);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(129, 36);
            this.buttonGoBack.TabIndex = 21;
            this.buttonGoBack.Text = "Go back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1378, 562);
            this.Controls.Add(this.panelRightContainer);
            this.Controls.Add(this.panelLeftImg);
            this.MinimumSize = new System.Drawing.Size(1187, 500);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelRightContainer.ResumeLayout(false);
            this.panelRightContainer.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelMail.ResumeLayout(false);
            this.panelMail.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftImg;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelRightContainer;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelHaveNoAccount;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Panel panelContainerPassword;
        private System.Windows.Forms.Panel panelContainerEmail;
        private System.Windows.Forms.Panel panelContainerUsername;
        private CircularProgressBar.CircularProgressBar cpbLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Button buttonGoBack;
    }
}