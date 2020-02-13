using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace CoMessage.Model.Common
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public Guid ID { get; set; } = Guid.NewGuid();

        /// <summary> --> UserInfo.ContactID </summary>
        [DataMember]
        public Guid AuthorID { get; set; } = Guid.Empty;

        [DataMember]
        public Guid ChatID { get; set; } = Guid.Empty;

        [DataMember]
        public MessageStatus Status { get; set; } = MessageStatus.Unknown;

        [DataMember]
        public /*virtual */MessageKind Kind
        {
            get => (null != Data) ? Data.Kind : MessageKind.Unknown;
        }

        [DataMember]
        public MessageData Data { get; set; } = new MessageData();

        public byte[] AsBinary(bool emptyIfNullOrNotSame =true)
            => DataAs<byte[]>(emptyIfNullOrNotSame);

        public Image AsImage(bool emptyIfNullOrNotSame =true)
            => DataAs<Image>(emptyIfNullOrNotSame);

        public string AsString(bool emptyIfNullOrNotSame =true)
            => DataAs<string>(emptyIfNullOrNotSame);

        T DataAs<T>(bool emptyIfNullOrNotSame =true) where T : class
        {
            return emptyIfNullOrNotSame
                    ? DataValueOrEmptyOrThrow<T>(emptyIfNullOrNotSame)
                    : Data.As<T>();
        }


        #region DataAs* is properties for using as the union initialization: new Message(){ ... DataAsString = text, ... }
        public byte[] DataAsBinary
        {
            get => AsBinary(false);
            set => Data.Set(value);
        }

        public Image DataAsImage
        {
            get => AsImage (false);
            set => Data.Set(value);
        }

        public string DataAsString
        {
            get => AsString(false);
            set => Data.Set(value);
        }
        #endregion

        [DataMember]
        public DateTime SendTime { get; set; } = DateTime.MinValue;

        [DataMember]
        public bool IsEdited { get; set; } = false;

        public bool IsValid { get => ID == Guid.Empty; }


        #region Convenient methods
        T DataValueOrEmptyOrThrow<T>(bool emptyIfNullOrNotSame =true) where T : class
        {
            if (Data == null || Data.Kind != MessageData.TypeToMessageKind<T>())
            {
                if (emptyIfNullOrNotSame) 
                    return default;

                throw new ArgumentNullException($"{nameof(Data)} is null");
            }

            return Data.As<T>();
        }
        #endregion /Convenient methods

        #region Statics
        public static Message Empty { get; } = new Message{ ID = Guid.Empty };
        #endregion /Statics
    }
}
