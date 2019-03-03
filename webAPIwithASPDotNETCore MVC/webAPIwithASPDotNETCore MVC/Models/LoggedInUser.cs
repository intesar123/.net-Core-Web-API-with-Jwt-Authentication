using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApp
{
    public class LoggedInUser
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
        public string UserRoleName { get; set; }
        public byte[] Photo { get; set; }

    }
}