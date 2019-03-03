using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mysqltest.Models
{
    public class ContactMessage
    {
        public int id { get; set; }
        public string name { get; set; }
        public string from { get; set; }
        public string ToCC { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public bool isread { get; set; }
        public bool isrep { get; set; }
        public string message { get; set; }
    }
}