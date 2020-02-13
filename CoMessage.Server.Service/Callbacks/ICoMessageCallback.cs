using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using CoMessage.Model;
using CoMessage.Model.Common;
using CoMessage.Model.Common.OperationResults;

namespace CoMessage.Server.Service.Callbacks
{
    //~ [ServiceContract]
    public interface ICoMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReceiveMessage(Message message);

        //[OperationContract] 
        //OperationCode EditMessage(Model.Interop.Message newMessage);

        [OperationContract(IsOneWay = true)]
        void DeleteMessage(Guid messageID);

        [OperationContract(IsOneWay = true)]
        void ServiceNotify(ServiceNotifyData notifyData);
    }
}
