using CoMessage.Model.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Extensions
{
    public static class BytesExtensions
    {
        public static Image AsImage(this byte[] bytes)
            => BytesToImage(bytes);

        internal static Image BytesToImage(byte[] bytes)
        {
            Image result;
            using (var ms = new MemoryStream(bytes))
                result = Image.FromStream(ms);

            return result;
        }

        public static UserInfo AsUserInfo(this byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
                return (UserInfo) new BinaryFormatter().Deserialize(ms);
        }
    }
}
