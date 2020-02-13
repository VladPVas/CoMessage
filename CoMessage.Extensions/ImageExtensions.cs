using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Extensions
{
    public static class ImageExtensions
    {
        public static byte[] AsBytes(this Image image, ImageFormat imageFormat =null)
            => ImageToBytes(image, imageFormat);


        public static byte[] ImageToBytes(Image image, ImageFormat imageFormat =null)
        {
            if (image == null)
                return new byte[0];

            imageFormat = imageFormat ?? ImageFormat.Png;
            using (var ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }

        public static int SizeInBytes(this Image image)
        {
            //~ if (ImageFormat.Jpeg.Equals(image.RawFormat))...
            //~ if (ImageFormat.Png .Equals(image.RawFormat))...
            //...

            if (image == null)
                return 0;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return (int)ms.Length;
            }
        }
    }
}
