using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using CoMessage.Extensions;
using CoMessage.Model.Common;
using CoMessage.Model.Common.OperationResults;
using CoMessage.Server.Service.Callbacks;

namespace CoMessage.Server.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CoMessageService : ICoMessageService
    {
        public OperationCode EditMessage(Message newMessage)
        {
            return OperationCode.Unknown;
        }

        public MessageArrayResult GetChatMessagesOfUser(Guid chatID, Guid userID)
        {
            if (!ChatHasUser(chatID, userID))
                return new MessageArrayResult();

            return new MessageArrayResult(Storage.GetChatMessages(chatID).ToArray());
        }

        public bool ChatHasUser(Guid chatID, Guid userID)
        {
            return Storage.ChatHasUser(chatID, userID);
        }

        public GuidResult Login(string login, string password)
        {
            var userInfo = Storage.GetUserByLogin(login);

            if (!userInfo.IsValid || userInfo.Password != password)
            {
                Console.WriteLine($"\n{DateTime.Now.ToUniversalTime()} The user with login '{login}' is not found.");
                return new GuidResult(OperationCode.E_LoginOrPasswordNotFound);
            }

            // Если вход уже выполнен, то сначала выйдем:
            if (_callbacksByUserID.ContainsKey(userInfo.ID))
                Logout(userInfo.ID);

            var callback = OperationContext.Current.GetCallbackChannel<ICoMessageCallback>();
            _callbacksByUserID[userInfo.ID] = callback;
            
            //Task.Run( () => callback.ServiceNotify( new ServiceNotifyData
            //{
            //    Code      = ServiceNotifyCode.S_Login,
            //    UserID    = userInfo.ID,
            //    InnerData = userInfo.AsBytes()
            //}) );

            Console.WriteLine($"\n{DateTime.Now.ToUniversalTime()} The user with login '{login}' has been logged.");

            return new GuidResult(userInfo.ID);
        }

        public void /*GuidResult*/ Logout(Guid userID)
        {
            if (!_callbacksByUserID.ContainsKey(userID))
                return; //~ new GuidResult(OperationCode.E_UserNotFound);

            _callbacksByUserID.Remove(userID);

            Console.WriteLine($"\n{DateTime.Now.ToUniversalTime()} The user with ID '{userID}' has been logout.");
            return; //~ new GuidResult(OperationCode.Success);
        }

        public GuidResult Signup(UserInfo userInfo)
        {
            Console.WriteLine($"\n{DateTime.Now.ToUniversalTime()} The user with login '{userInfo.Login}' is trying to signup...");

            if (userInfo == null)
            {
                Console.WriteLine($"\n{DateTime.Now.ToUniversalTime()} The user info is empty.");
                return new GuidResult(OperationCode.E_RequiredDataIsNull);
            }

            if (Storage.IsUserExistByLogin(userInfo.Login))
            {
                Console.WriteLine($"\n{DateTime.Now.ToUniversalTime()} The user with login '{userInfo.Login}' already exist.");
                return new GuidResult(OperationCode.E_LoginAlreadyExist);
            }

            bool successfull = Storage.CreateUser(userInfo);

            return new GuidResult(
                successfull
                ? OperationCode.Success
                : OperationCode.E_Unknown
            );
        }

        public OperationCode SendMessage(Message message, Guid chatID)
        {
            if (!Storage.IsChatExist(chatID))
                return OperationCode.E_ChatNotFound;

            if (Storage.IsMessageExsistByID(message.ID))
                return OperationCode.E_MessageAlreadyExist;

            
            Storage.AddMessageToChat(message);

            var userIDs = GetChatUserIDs(chatID);
            if (0 == userIDs.Count)
                return OperationCode.E_ChatHasNoUsers;

            // Пройдём по всем участникам чата:
            foreach (var userID in userIDs)
            {
                var callback = GetCallbackByUserID(userID);
                if (callback == null)
                    continue;

                // Нет проверки на доставку конкретному пользователю:
                callback.ReceiveMessage(message);
            }

            return OperationCode.Success;
        }

        #region Convience methods
        static List<Guid> GetChatUserIDs(Guid chatID)
        {
            return chatID.IsEmpty()
                    ? new List<Guid>(0)
                    : Storage.GetChatUserIDs(chatID);
        }

        static Guid GetUserID(Guid contactID)
        {
            if (!_userID_X_contactID.ContainsKey(contactID))
                return Guid.Empty;

            return _userID_X_contactID[contactID];
        }

        static Guid GetContactID(Guid userID)
        {
            if (!_userID_X_contactID.ContainsKey(userID))
                return Guid.Empty;

            return _userID_X_contactID[userID];
        }

        static ICoMessageCallback GetCallbackByUserID(Guid userID)
        {
            if (userID.IsEmpty())
                return null;

            _callbacksByUserID.TryGetValue(userID, out var callback);

            return callback;
        }

        static ICoMessageCallback GetCallbackByContactID(Guid contactID) 
            => GetCallbackByUserID( GetUserID(contactID) );

        static ICoMessageCallback GetCallbackByUser(UserInfo userInfo) 
            => GetCallbackByUserID(userInfo.ID);

        #endregion /Convience methods

        /// <summary> ContactID => Callback </summary>
        static Dictionary<Guid,ICoMessageCallback> _callbacksByUserID  = new Dictionary<Guid,ICoMessageCallback>();

        static Dictionary<Guid,Guid>               _userID_X_contactID = new Dictionary<Guid,Guid>();

    }
}
