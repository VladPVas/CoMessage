using CoMessage.Model;
using CoMessage.Model.Common.OperationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common
{
    [DataContract]
    public class ServiceNotifyData
    {
        [DataMember]
        public Guid              UserID        { get; set; } = Guid.Empty;

        [DataMember]
        public ServiceNotifyCode Code          { get; set; } = ServiceNotifyCode.Unknown;

        [DataMember]
        public OperationCode     OperationCode { get; set; } = OperationCode.Unknown;

        [DataMember]
        public byte[]            InnerData     { get; set; } = null;

    }
}
