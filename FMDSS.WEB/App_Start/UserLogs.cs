using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FMDSS.WEB.App_Start
{
    public class UserLogs
    {
        [BsonId]
        public ObjectId LogId { get; set; }
        public string ssoId { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string IPAddress { get; set; }
        public string BrowserName { get; set; }
        public string DateTime { get; set;}

        public string Type { get; set; }
        public string BrowserType { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string MajorVersion { get; set; }
        public string MinorVersion { get; set; }
        public string Platform { get; set; }
        public string IsBeta { get; set; }
        public string IsCrawler { get; set; }
        public string IsAOL { get; set; }
        public string IsWin16 { get; set; }
        public string IsWin32 { get; set; }
        public string SupportsFrames { get; set; }

        public string SupportsTables { get; set; }

        public string SupportsCookies { get; set; }
        public string SupportsVBScript { get; set; }
        public string upportsJavaScript { get; set; }
        public string SupportsJavaApplets { get; set; }
        public string SupportsActiveXControls { get; set; }
        public string SupportsJavaScriptVersion { get; set; }



    }

    
}