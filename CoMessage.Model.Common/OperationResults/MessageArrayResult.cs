using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common.OperationResults
{
    [DataContract]
    public class MessageArrayResult : OperationResultT< Message[] >
    {
        public MessageArrayResult() : base()
        {}

        public MessageArrayResult(Message[] messages) : base(messages)
        {}

        public MessageArrayResult(OperationCode code) : base(code)
        {}

        public MessageArrayResult(Message[] messages, OperationCode code) : base(messages, code)
        {}
    }
}
