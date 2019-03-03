using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mysqltest.Models
{
    public class Projects
    {
        [Required]
        public string id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        [AllowHtml]
        public string pdesc { get; set; }
        [Required]
        public HttpPostedFileBase image { get; set; }

        public string imagepath { get; set; }

        public string txtEditor { get; set; }
    }
}