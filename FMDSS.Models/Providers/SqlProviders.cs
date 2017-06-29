using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.Models.Providers
{
   public  class SqlProviders
    {
        public class ProviderSetting
        {
            public ProviderSetting() { }
            public ProviderSetting(int companyId, string privateconnectionString)//, int defaultcontext
            {
                
                    CompanyId = companyId;
                    Privateconnectionstring = privateconnectionString;
                    //ApiUrl = apiUrl;
                    //LoginName = loginname;
                    //Password = password;
                    //CompanyKey = companykey;
               
            }
            public int CompanyId { get; set; }
            public string Privateconnectionstring { get; set; }
            public string ApiUrl { get; set; }
            public string LoginName { get; set; }
            public string Password { get; set; }
            public string CompanyKey { get; set; }
        }
    }
}
