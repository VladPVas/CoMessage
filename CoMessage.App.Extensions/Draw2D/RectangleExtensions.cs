using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CoMessageApp.Extensions.Draw2D
{

    public static class RectangleExtensions
    {
        /// <summary>
        /// Return the right-top point.
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static Point RightTop(this Rectangle self, int dx =0, int dy =0)
        {
            return new Point(self.Right +dx, self.Top +dy);
        }
        public static PointF RightTopF(this Rectangle self, int dx =0, int dy =0)
            => RightTop(self, dx, dy).ToPointF();

        public static Point RightBottom(this Rectangle self, int dx =0, int dy =0)
        {
            return new Point(self.Right +dx, self.Bottom +dy);
        }
        public static PointF RightBottomF(this Rectangle self, int dx =0, int dy =0)
            => RightBottom(self, dx, dy).ToPointF();


        public static Point LeftTop(this Rectangle self, int dx =0, int dy =0)
        {
            return new Point(self.Left +dx, self.Top +dy);
        }
        public static PointF LeftTopF(this Rectangle self, int dx =0, int dy =0)
            => LeftTop(self, dx, dy).ToPointF();

        public static Point LeftBottom(this Rectangle self, int dx =0, int dy =0)
        {
            return new Point(self.Left +dx, self.Bottom +dy);
        }
        public static PointF LeftBottomF(this Rectangle self, int dx =0, int dy =0) 
            => LeftBottom(self, dx, dy).ToPointF();


        public static Rectangle AddLocation(this Rectangle self, Rectangle addRectangle)
        {
            return self.AddLocation(addRectangle.Location);
        }

        public static Rectangle AddLocation(this Rectangle self, Point addLocation)
        {
            return new Rectangle(
                self.X + addLocation.X,
                self.Y + addLocation.Y,
                self.Width,
                self.Height
            );
        }

        public static Rectangle AddSize(this Rectangle self, Size size)
        {
            return self.AddSize(size.Width, size.Height);
        }
        public static Rectangle AddSize(this Rectangle self, int dx, int dy)
        {
            return new Rectangle(self.X, self.Y, self.Width +dx, self.Height +dy);
        }

        public static Rectangle Shift(this Rectangle self, int dx, int dy)
        {
            return new Rectangle(self.X +dx, self.Y +dy, self.Width, self.Height);
        }


        public static Rectangle ResetXY(this Rectangle self)
        {
            self.X = self.Y = 0;
            return self;
        }

        public static Rectangle DockTo(this Rectangle self, Rectangle coveringRectangle, params DockStyle[] dockTo)
        {
            foreach (var dock in dockTo)
                self = self.DockTo(coveringRectangle, dock, true);

            return self.AddLocation(coveringRectangle);
        }

        public static Rectangle DockTo(this Rectangle self, Rectangle coveringRectangle, DockStyle dockTo, bool asNeedLocation =false)
        {
            Rectangle cr = coveringRectangle.ResetXY();

            switch (dockTo)
            {
            case DockStyle.Top:    self.Y = 0;                      break;
            case DockStyle.Bottom: self.Y = cr.Bottom -self.Height; break;
            case DockStyle.Left:   self.X = 0;                      break;
            case DockStyle.Right:  self.X = cr.Right  -self.Width;  break;
            }

            return asNeedLocation 
                ? self 
                : self.AddLocation(coveringRectangle);
        }

        public static SizeF ToSizeF(this Rectangle self)
        {
            return new SizeF(self.Width, self.Height);
        }
    }
}
