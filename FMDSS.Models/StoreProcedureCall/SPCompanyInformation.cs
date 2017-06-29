using FMDSS.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMDSS.Models.Providers;

namespace FMDSS.Models.StoreProcedureCall
{

  public  class SPCompanyInformation
    {
        private readonly dynamic _companyinfo;
        private readonly SqlProviders.ProviderSetting _providersSettings;
        public SPCompanyInformation(dynamic settings)
        {
            if (settings != null)
            {
                _companyinfo = settings;
                _providersSettings = new SqlProviders.ProviderSetting(_companyinfo.CompanyID, _companyinfo.PrivateConnectionString);
                if (_companyinfo.CompanyID == 0 && _companyinfo.EnvironmentId == 0)
                    throw new Exception("Incorrect URL. Please verify the URL and try again");
            }
            else
            {
                //throw new MemberAccessException();
            }
        }
        public DataTable GetCompanyDetails(long companyID)
        {
            return SqlHelper.ExecuteDataTable(_providersSettings.Privateconnectionstring, CommandType.StoredProcedure, Procedures.GetCompanyDetails,
                    new SqlParameter("@CompanyID", _providersSettings.CompanyId));
        }
    }
}
