using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoMessage.Model.Common;

namespace CoMessageApp.Models
{
    public class Chat
    {
        public Guid          ID       { get; set; } = Guid.Empty;
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
