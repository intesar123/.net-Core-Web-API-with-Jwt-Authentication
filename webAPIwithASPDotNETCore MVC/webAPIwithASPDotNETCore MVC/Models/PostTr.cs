using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApp.Models
{
    public class PostTr
    {
        [Key]
        public int id { get; set; }
        public int postid { get; set; }
        public string content { get; set; }
        public int sequence { get; set; }
    }
}