using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.App.Extensions.Draw2D
{
    public static class SizeExtensions
    {
        public static Rectangle ToRectangle(this Size self, int x =0, int y =0)
        {
            return new Rectangle(x, y, self.Width, self.Height);
        }

        public static Rectangle ToRectangle(this Size self, Point location)
        {
            return ToRectangle(self, location.X, location.Y);
        }

        public static Rectangle ToRectangle(this Size self, Rectangle locationRectangle)
        {
            return ToRectangle(self, locationRectangle.X, locationRectangle.Y);

        }
    }
}
