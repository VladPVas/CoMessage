using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common
{
    public enum MessageStatus
    {
        Unknown = 0,
        NotDelivered,
        Sending,
        Receving = Sending,
        Delivered,
        Seen // Viewed
    }
}
