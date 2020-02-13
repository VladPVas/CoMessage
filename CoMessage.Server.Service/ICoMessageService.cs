using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using CoMessage.Model;
using CoMessage.Model.Common;
using CoMessage.Model.Common.OperationResults;
using CoMessage.Server.Service.Callbacks;

namespace CoMessage.Server.Service
{
    [ServiceContract(
        Namespace = "CoMessage.Server.Service"
        , CallbackContract = typeof(ICoMessageCallback)
        , SessionMode = SessionMode.Required
    )]
    public interface ICoMessageService
    {
        [OperationContract]
        OperationCode SendMessage(Message message, Guid chatID);


        [OperationContract]
        OperationCode EditMessage(Message newMessage);

        [OperationContract]
        MessageArrayResult GetChatMessagesOfUser(Guid chatID, Guid userID);

        [OperationContract]
        bool ChatHasUser(Guid chatID, Guid userID);

        [OperationContract]
        GuidResult Signup(UserInfo userInfo);

        [OperationContract(IsOneWay =false)]
        GuidResult Login(string login, string password);

        [OperationContract]
        void /*GuidResult*/ Logout(Guid userID);
    }
}
