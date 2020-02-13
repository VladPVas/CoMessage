using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common.OperationResults
{
    [DataContract]
    public class OperationResultT<TResultData> 
        // where TResultData : new() -- нельзя, т.к. у Array (MessageArrayResult) нет констр по уполчанию.
    {
        [DataMember]
        public OperationCode Code { get; set; }

        [DataMember]
        public TResultData Result { get; set; }

        #region Constructors
        public OperationResultT()
            : this(default, OperationCode.Unknown)
        {}

        public OperationResultT(OperationCode code)
        {
            Code   = code;
            Result = default;
        }

        public OperationResultT(TResultData result)
        {
            Code   = OperationCode.Success;
            Result = result;
        }

        public OperationResultT(TResultData result, OperationCode code)
        {
            Result = result;
            Code   = code;
        }
        #endregion /Constructors

        public static implicit operator OperationCode(OperationResultT<TResultData> or) => or.Code;
        public static implicit operator TResultData  (OperationResultT<TResultData> or) => or.Result;

        //public T DataAs<T>()
        //{
        //    BinarySerializer


        //    var result = Data as TData;
        //    if (result == null)
        //        return default(TData);

        //    return result;
        //}
    }
}
