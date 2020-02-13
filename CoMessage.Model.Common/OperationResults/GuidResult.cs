using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common.OperationResults
{
    public class GuidResult : OperationResultT<Guid>
    {
        public GuidResult() : base()
        {}

        public GuidResult(Guid guid) : base(guid)
        {}

        public GuidResult(OperationCode code) : base(code)
        {}

        public GuidResult(Guid guid, OperationCode code) : base(guid, code)
        {}
    }
}
