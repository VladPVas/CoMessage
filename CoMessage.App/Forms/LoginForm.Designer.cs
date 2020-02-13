namespace CoMessageApp.Forms
{
    partial class LoginForm
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btSignUp = new System.Windows.Forms.Button();
            this.btLogIn = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(14, 16);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(37, 13);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "e-mail:";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(76, 13);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(218, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.WordWrap = false;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 42);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(76, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbForgotPassword.Location = new System.Drawing.Point(73, 62);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.Size = new System.Drawing.Size(91, 13);
            this.llbForgotPassword.TabIndex = 4;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "Forgot password?";
            this.llbForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgotPassword_LinkClicked);
            // 
            // btSignUp
            // 
            this.btSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSignUp.Location = new System.Drawing.Point(12, 106);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(75, 23);
            this.btSignUp.TabIndex = 7;
            this.btSignUp.Text = "Sign Up";
            this.btSignUp.UseVisualStyleBackColor = true;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // btLogIn
            // 
            this.btLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btLogIn.Location = new System.Drawing.Point(138, 106);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 23);
            this.btLogIn.TabIndex = 5;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(219, 106);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 141);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.llbForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbEmail);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 297);
            this.MinimumSize = new System.Drawing.Size(322, 180);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel llbForgotPassword;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Button btExit;
    }
}