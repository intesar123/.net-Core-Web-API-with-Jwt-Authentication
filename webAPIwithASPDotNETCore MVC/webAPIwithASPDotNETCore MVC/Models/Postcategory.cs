using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Models
{
    public class Postcategory
    {
      
        public int id { get; set; }
      
        [StringLength(255, MinimumLength = 4)]
        public string name {get;set;}
        public string pdesc { get; set; }
        public string pcatcategory { get; set; }
        public byte[] pimage { get; set; }

        public int isapproved { get; set; }

    }
}