using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.App.Extensions
{
    public static class NumericsExtensions
    {
        public static bool IsOdd(this int self)
        {
            return (self % 2) == 1;
        }
    }
}
