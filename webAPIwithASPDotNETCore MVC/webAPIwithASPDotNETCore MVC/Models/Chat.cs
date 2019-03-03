using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teleradiology.Models
{
    public class Chat
    {
        public string sender { get; set; }
        public string recipient { get; set; }
        public DateTime time { get; set; }
        public string content { get; set; }

        public string isunread { get; set; }
    }
}