using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mysqltest.Models
{
    public class UserQuestions
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Question { get; set; }    
        public DateTime PDateTime { get; set; }
        public int IsApproved { get; set; } 
    }
}