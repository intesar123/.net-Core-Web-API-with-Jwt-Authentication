using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Models
{
    public class App_Demos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime datetime { get; set; }
        public string UserId { get; set; }
        public string DemoContent { get; set; }
        public string image { get; set; }
        public int Isverified { get; set; }
        [AllowHtml]
        public string Ddesc { get; set; }
        [AllowHtml]
        public string editor { get; set; }

    }
}