using CoMessage.Model.Common;
using CoMessageApp.CoMessageService;
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

using CommonModel = CoMessage.Model.Common;
using CoMessage.Model.Common.OperationResults;
using System.ServiceModel;
using CoMessage.Extensions;

namespace CoMessageApp.Forms
{
    public partial class LoginForm : Form, CoMessageApp.CoMessageService.ICoMessageServiceCallback
    {
        public UserInfo _userInfo { get; } = Program.UserInfo;

        #region Fields
        readonly Pen   _blockPen   = new Pen(SystemColors.ButtonShadow, 2);
        readonly Brush _blockBrush = new SolidBrush(Color.White);
        Rectangle      _bottomRectangle;

        CoMessageServiceClient _service = null;
        //~ InstanceContext        _thisInstanceContext = null;
        #endregion

        void ResizeBottomRectangle()
        {
            _bottomRectangle.Location = new Point(0, btSignUp.Top -12);
            _bottomRectangle.Size     = new Size(Width, Height -btExit.Top -12);
        }

        public LoginForm()
        {
            InitializeComponent();

            Program.UserInfo.LoginChanged    += UserInfo_LoginChanged;
            Program.UserInfo.PasswordChanged += UserInfo_PasswordChanged;

            _service = new CoMessageServiceClient(new InstanceContext(this));
        }

        ICoMessageService Service
        {
            get
            {
                if (_service == null)
                    _service = new CoMessageServiceClient(new InstanceContext(this));

                if (_service.State == CommunicationState.Faulted)
                    _service.Close();
                
                if (_service.State == CommunicationState.Closed)
                    _service.Open();

                return _service;
            }
        }

        private void UserInfo_LoginChanged(object sender, string newLogin)
        {
            txtLogin.Text = newLogin;
            btLoginSetEnableState();
        }

        private void UserInfo_PasswordChanged(object sender, string newPassword)
        {
            txtPassword.Text = newPassword;
            btLoginSetEnableState();
        }

        private void btLoginSetEnableState()
        {
            btLogIn.Enabled = txtPassword.Text.Length > 0 && txtLogin.Text.Length > 0;
        }

        public new DialogResult ShowDialog()
        {
            return base.ShowDialog();
        }

        /// <summary> Делает регистрацию пользователя. </summary>
        /// <returns> true -- успешно. </returns>
        public bool DoSignUp()
        {
            Service.Signup(_userInfo);
            //~~~
            //var userID = _server.Signup(_userInfo);
            //if (userID.Result.IsEmpty())
            //    return false;

            //_userInfo.ID = userID;

            return true;
        }

        #region Overrides
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    e.Graphics.FillRectangle(_blockBrush, _bottomRectangle);
        //    e.Graphics.DrawLine(_blockPen, _bottomRectangle.Location, _bottomRectangle.RightTop());
        //}
        #endregion


        #region Events Handlers
        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ResizeBottomRectangle();
            
            UserInfo_LoginChanged   (this, _userInfo.Login);
            UserInfo_PasswordChanged(this, _userInfo.Password);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            ResizeBottomRectangle();
            Invalidate();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(_blockBrush, _bottomRectangle);
            g.DrawLine(_blockPen, _bottomRectangle.Location, _bottomRectangle.RightTop());
        }
        #endregion

        private void btLogIn_Click(object sender, EventArgs e)
        {
            _userInfo.Login    = txtLogin   .Text.Trim();
            _userInfo.Password = txtPassword.Text.Trim();

            var savedCursor = Cursor;
            Cursor = Cursors.WaitCursor;
            var result = Service.Login(_userInfo.Login, _userInfo.Password);
            Cursor = savedCursor;

            if (result.Result.IsEmpty())
            {
                MessageBox.Show(
                    "Can't login."
                    , "Error!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                );
                this.DialogResult = DialogResult.None;
            }
            else
                this.DialogResult = DialogResult.OK;

            return;
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            Hide();

            using (var frmSignUp = new SignUpForm())
            {
                var dialogResult = frmSignUp.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    DoSignUp();
            }

            Show();
        }

        public void ReceiveMessage(CommonModel.Message message)
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage(Guid messageID)
        {
            return;
        }

        public void ServiceNotify(ServiceNotifyData notifyData)
        {
            if (notifyData.Code == ServiceNotifyCode.E_Login)
            {
                MessageBox.Show(
                    Program.GetMessageByOperationCode(notifyData.OperationCode)
                    , "Error!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation
                );
                return;
            }

            if (notifyData.Code == ServiceNotifyCode.S_Login)
            {
                _userInfo.ID = notifyData.UserID;
                var newUserInfo = notifyData.InnerData.AsUserInfo();
                if (newUserInfo == null)
                    MessageBox.Show("Fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show(
                    "Login successfull: " + notifyData.UserID.ToString()
                    , "Information"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                );
                return;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            btLoginSetEnableState();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btLoginSetEnableState();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = this.DialogResult == DialogResult.None;
        }
    }
}
