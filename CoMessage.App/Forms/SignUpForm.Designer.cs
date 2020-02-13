namespace CoMessageApp.Forms
{
    partial class SignUpForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNickname = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(218, 138);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSignUp
            // 
            this.btSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSignUp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSignUp.Location = new System.Drawing.Point(137, 138);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(75, 23);
            this.btSignUp.TabIndex = 8;
            this.btSignUp.Text = "Sign Up";
            this.btSignUp.UseVisualStyleBackColor = true;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(115, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 67);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(115, 38);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(179, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.WordWrap = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(14, 41);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(37, 13);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "e-mail:";
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Location = new System.Drawing.Point(14, 15);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(58, 13);
            this.lbNickname.TabIndex = 0;
            this.lbNickname.Text = "Nickname:";
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNickname.Location = new System.Drawing.Point(115, 12);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(179, 20);
            this.txtNickname.TabIndex = 1;
            this.txtNickname.WordWrap = false;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(13, 93);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(93, 13);
            this.lbConfirmPassword.TabIndex = 6;
            this.lbConfirmPassword.Text = "Confirm password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(115, 90);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(179, 20);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.btSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 174);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lbNickname);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbEmail);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(322, 180);
            this.Name = "SignUpForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUpForm_Paint);
            this.Resize += new System.EventHandler(this.SignUpForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
    }
}