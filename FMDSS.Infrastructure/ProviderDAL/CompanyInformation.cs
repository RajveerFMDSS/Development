using FMDSS.CustomModels.Models;
using FMDSS.Infrastructure.CommanModel;
using FMDSS.Interface.Interface;
using EntityCall= FMDSS.Models.StoreProcedureCall;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.Infrastructure.ProviderDAL
{
   public class CompanyInformation:ICompany
    {
        private readonly Company.GetDetailsResponse _Companyinformation;
        public CompanyInformation(Company.GetDetailsResponse companyinfo)
        {
            if (companyinfo.CompanyID == 0)
                throw new Exception("Incorrect URL. Please verify the URL and try again");
            //For DAL
            _Companyinformation = GetCompanyDetails(companyinfo);
        }

        private Company.GetDetailsResponse GetCompanyDetails(Company.GetDetailsResponse comp)
        {
            return new Company.GetDetailsResponse
            {
                CompanyID = comp.CompanyID,
                CompanyName = comp.CompanyName,
                Status = comp.Status,
                Url = comp.Url
            };
        }

        public GetDetailsResponseData Details()
        {
            GetDetailsResponseData response = new GetDetailsResponseData();
            try
            {
                DataTable dt = new EntityCall.SPCompanyInformation(_Companyinformation).GetCompanyDetails(_Companyinformation.CompanyID);
                if (dt.IsValid())
                {
                    DataRow row = dt.Rows[0];
                    var result = new Company.GetDetailsResponse()
                    {
                        CompanyName = row.GetString("Name"),
                        CompanyID = row.GetInt("CompanyID"),
                        Url = row.GetString("CompanyStatus"),
                        Status = row.GetInt("CompanyStatus")
                    };
                    response.Data = result;
                }

            }
            catch (Exception ex)
            {
                //response = Response.Failed(response, ex, "", System.Reflection.MethodBase.GetCurrentMethod().Name, _companyinfo.PrivateConnectionString, _companyinfo.CompanyID);
            }
            return response;
        }
    }
}
