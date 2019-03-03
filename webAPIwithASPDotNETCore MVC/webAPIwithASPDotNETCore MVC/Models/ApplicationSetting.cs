using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApp.Models
{
    public class ApplicationSetting
    {
        public string CompanyName { get; set; }
        public string Version { get; set; }
        public DateTime CreateDate { get; set; }
        public string DeploymentName { get; set; }
        public bool isUnicodeDb { get; set; }

    }
}