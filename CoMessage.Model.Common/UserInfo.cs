using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common
{
    [Serializable]
    [DataContract]
    public class UserInfo : System.ComponentModel.INotifyPropertyChanged
    {
        public UserInfo()
        {
            Init(false, false);
        }
        public UserInfo(bool generateID, bool generateContactID)
        {
            Init(generateID, generateContactID);
        }

        protected void Init(bool generateID, bool generateContactID)
        {
            _ID        = generateID        ? Guid.NewGuid() : Guid.Empty;
            _ContactID = generateContactID ? Guid.NewGuid() : Guid.Empty;
        }

        public bool IsValid { get => ID != Guid.Empty; }

        public byte[] AsBytes()
        {
            using (var ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, this);
                return ms.ToArray();
            }
        }

        /// <summary> Внутренний ID в системе. </summary>
        [DataMember]
        public Guid ID 
        {
            get => _ID;

            set
            {
                if (value == _ID)
                    return;

                _ID = value;
                IDChanged?      .Invoke(this, _ID);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ID)));
            }
        } 
        protected Guid _ID;

        /// <summary> ID для общения с контактами. </summary>
        [DataMember]
        public Guid ContactID 
        {
            get => _ContactID; 
            set
            {
                if (value == _ContactID)
                    return;

                _ContactID = value;
                ContactIDChanged?.Invoke(this, _ContactID);
                PropertyChanged? .Invoke(this, new PropertyChangedEventArgs(nameof(ContactID)));

            }
        } 
        protected Guid _ContactID;

        /// <summary> Login / e-mail. </summary>
        [DataMember]
        public string Login 
        { 
            get => _Login;
            set
            {
                var newLogin = value.ToLower();
                if (newLogin == _Login)
                    return;

                _Login = newLogin;
                LoginChanged?   .Invoke(this, _Login);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Login)));

            }
        } 
        protected string _Login = string.Empty;

        [DataMember]
        public string Password
        {
            get => _Password;
            set
            {
                if (value == _Password)
                    return;

                _Password = value;
                PasswordChanged?.Invoke(this, _Password);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));

            }
        }
        protected string _Password = string.Empty;

        [DataMember]
        public string Nickname
        {
            get => _Nickname;
            set
            {
                if (value == _Nickname)
                    return;

                _Nickname = value;
                NicknameChanged?.Invoke(this, _Nickname);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nickname)));

            }
        }
        protected string _Nickname = string.Empty;
        
        [DataMember]
        public Image Avatar
        {
            get => _Avatar;
            set
            {
                if (value == _Avatar)
                    return;

                _Avatar = value;
                AvatarChanged?  .Invoke(this, _Avatar);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Avatar)));
            }
        }
        protected Image _Avatar = null;

        #region Events
        public event EventHandler<Guid>          IDChanged;
        public event EventHandler<Guid>          ContactIDChanged;
        public event EventHandler<string>        LoginChanged;
        public event EventHandler<string>        PasswordChanged;
        public event EventHandler<string>        NicknameChanged;
        public event EventHandler<Image>         AvatarChanged;

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
