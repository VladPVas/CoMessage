using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CoMessage.Model.Common
{
    [DataContract]
    public class MessageData
    {
        [DataMember]
        public MessageKind Kind { get; protected set; } = MessageKind.Unknown;

        public MessageData()             { _data = null; }
        public MessageData(byte[] bytes) { Set(bytes);   }
        public MessageData(Image  image) { Set(image);   }
        public MessageData(string text)  { Set(text);    }

        public byte[] AsBinary() { return (byte[])_data; }

        public Image  AsImage()  { return (Image)_data;  }

        public string AsString() { return (string)_data; }

        public T As<T>() where T : class
        {
            T t = default;

            switch (t)
            {
                case string _: return (AsString() as T);
                case byte[] _: return (AsBinary() as T);
                case Image  _: return (AsImage()  as T);
            }
            // вместо этого:
            //if (t is string) return (AsString() as T);
            //if (t is byte[]) return (AsBinary() as T);
            //if (t is Image ) return (AsImage()  as T);

            throw new ArgumentOutOfRangeException($"{typeof(T).Name} is not supported in MessageData as the data type");
        }

        #region Conversions operators
        public static implicit operator byte[](MessageData messageData) => messageData.AsBinary();
        public static implicit operator Image (MessageData messageData) => messageData.AsImage ();
        public static implicit operator string(MessageData messageData) => messageData.AsString();
        
        public static MessageData operator +(MessageData self, string text)
        {
            self.Set(self.AsString() +text);
            return self;
        }
        #endregion

        #region 
        public static MessageKind TypeToMessageKind<T>()
        // where T : class -- не нужен, т.к. "is" для "всего" подходит
        {
            T t = default;

            if (t is string) return MessageKind.Text;
            if (t is byte[]) return MessageKind.Binary;
            if (t is Image ) return MessageKind.Image;

            return MessageKind.Unknown;
        }

        #endregion


        public void Set(byte[] bytes)
        {
            byte[] oldBytes = _data as byte[];
            if (object.ReferenceEquals(bytes, oldBytes))
                return;


            _data = bytes;
            Kind = MessageKind.Binary;
        }
        
        public void Set(Image image) 
        {
            Image oldImage = _data as Image;
            if (object.ReferenceEquals(image, oldImage))
                return;

            if (oldImage != null)
                oldImage.Dispose();
            
            _data = image;
            Kind = MessageKind.Image;
        }

        public void Set(string text)
        {
            string oldString = _data as string;
            if (object.ReferenceEquals(text, oldString))
                return;

            _data = text;
            Kind = MessageKind.Text;
        }

        [DataMember]
        protected object _data;
    }
}
