using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.Models.Helpers
{

    public enum Status
    {
        Active=1,
        DeActive=0
    }

    
   public  class Procedures
    {
        internal static string GetCompanyDetails = "AdminConfiguration.GetCompanyByUrl";
    }
}
