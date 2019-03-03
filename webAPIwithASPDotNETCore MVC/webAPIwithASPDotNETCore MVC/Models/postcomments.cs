using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mysqltest.Models
{
    public class postcomments
    {
        public int id { get; set; }
        public int postid { get; set; }
        public string useremail { get; set; }
        public string comment { get; set; }
        public DateTime dtime { get; set; }

    }
}