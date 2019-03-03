using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApp.Models
{
    public class Settings
    {
        [DisplayName("Category Tile Size")]
        [Required]
        public int tile { get; set; }
        [DisplayName("Page Size")]
        [Required]
        public int pagesize { get; set; }
        [DisplayName("Email Page Size")]
        [Required]
        public int emailpagesize { get; set; }
        [DisplayName("Print Crystal Report")]
        [Required]
        public bool isrptreport { get; set; }

        [DisplayName("Host IP")]
        [Required]
        public string hostip { get; set; }
        [DisplayName("Host Port")]
        [Required]
        public int hostport { get; set; }

        [DisplayName("Left Menu Size")]
        [Required]
        public int leftmenusize { get; set; }
        
    }
}