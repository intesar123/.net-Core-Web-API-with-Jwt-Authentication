using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Models
{
    [ValidateInput(false)]
    public class Post
    {
        [Key]
        public int id { get; set;}
       
        public string title { get; set; }
        public DateTime datetime { get; set; }
        public List<Postcategory> pcategory { get; set; }
        public string pcat { get; set; }
        public int pcatTopic { get; set; }
        public string pcatTopicName { get; set; }
        public string pdesc { get; set; }
        public string isverified { get; set; }
        public string postcontent { get; set; }
        [AllowHtml]
        public string editor { get; set; }
        public string image { get; set; }
        public string pagenum { get; set; }
        public List<PostTr> posttr { get; set; }
        public string catimage { get; set; }

        public string userid { get; set; }
        public string username { get; set; }

    }
}