using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.CustomModels.Models
{
    public class Company
    {
        public class GetDetailsResponse
        {
            public string CompanyName { get; set; }
            public string Url { get; set; }
            public int Status { get; set; }
            public long CompanyID { get; set; }
            public string PrivateConnectionString { get; set; }
        }

    }
}
