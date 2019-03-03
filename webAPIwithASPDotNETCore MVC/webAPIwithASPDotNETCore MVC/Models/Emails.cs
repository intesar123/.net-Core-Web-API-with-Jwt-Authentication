using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mysqltest.Models
{
    public class Emails
    {
        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public DateTime dtime { get; set; }
        public int isread { get; set; }
        public string time { get; set; }

    }
}