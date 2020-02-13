using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Extensions
{
    public static class GuidExtensions
    {
        public static bool IsEmpty(this Guid self)
        {
            return self == Guid.Empty;
        }
    }
}
