using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessageApp.Extensions.Draw2D
{
    public static class PointExtensions
    {
        public static Point Add(this Point self, Point addPoint)
        {
            return new Point(self.X + addPoint.X, self.Y + addPoint.Y);
        }

        public static PointF ToPointF(this Point self)
        {
            return new PointF(self.X, self.Y);
        }
    }
}
