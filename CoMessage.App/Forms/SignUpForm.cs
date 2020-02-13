using CoMessageApp.Extensions.Draw2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoMessageApp.Forms
{
    public partial class SignUpForm : Form
    {
        #region Fields
        readonly Pen   _blockPen   = new Pen(SystemColors.ButtonShadow, 2);
        readonly Brush _blockBrush = new SolidBrush(Color.White);
        Rectangle      _bottomRectangle;
        #endregion

        void ResizeBottomRectangle()
        {
            _bottomRectangle.Location = new Point(0, btSignUp.Top -12);
            _bottomRectangle.Size = new Size(Width, Height - btCancel.Top - 12);
        }

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            Program.UserInfo.Nickname = txtNickname.Text;
            Program.UserInfo.Login    = txtLogin.Text;
            Program.UserInfo.Password = txtPassword.Text;
        }

        private void SignUpForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(_blockBrush, _bottomRectangle);
            g.DrawLine(_blockPen, _bottomRectangle.Location, _bottomRectangle.RightTop());
        }

        private void SignUpForm_Resize(object sender, EventArgs e)
        {
            ResizeBottomRectangle();
            Invalidate();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            ResizeBottomRectangle();
            btSignupSetEnableState();
        }

        private void btSignupSetEnableState()
        {
            btSignUp.Enabled =
                   txtLogin.Text.Length > 0
                && txtPassword.Text == txtConfirmPassword.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btSignupSetEnableState();
        }
    }
}
