using FMDSS.CustomModels.Models;
using FMDSS.Infrastructure.CommanModel;
using FMDSS.Interface;
using FMDSS.Interface.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace FMDSS.Infrastructure
{
   public  class RequestManager:IRequestManager
    {
        private readonly Company.GetDetailsResponse _companyinfo;
        public RequestManager()
        {
            string appUrl = "localhost:1843";//GetAppUrl();
            if (!string.IsNullOrEmpty(appUrl) && _companyinfo == null)
            {
                try
                {
                    _companyinfo = GetCompanyInfo(appUrl);
                }
                catch (Exception ex)
                {
                    if (!File.Exists(HttpContext.Current.Server.MapPath("~/Errorlog.txt")))
                        File.WriteAllLines(HttpContext.Current.Server.MapPath("~/Errorlog.txt"), new[] { ex.ToString() });
                    else
                        File.AppendAllLines(HttpContext.Current.Server.MapPath("~/Errorlog.txt"), new[] { ex.ToString() });
                    //SqlManager.InsertLogEntries(ex.ToString(), "ACN-RequestManager method", "RequestManager()", _companyinfo == null ? Providers.Utility.Config.AuthContext : _companyinfo.PrivateConnectionString);
                }
            }
        }


        private string GetAppUrl()
        {

            string appUrl = String.Empty;
            try
            {
                if (HttpContext.Current.Request.UrlReferrer != null)
                {
                    if (HttpContext.Current.Request.UrlReferrer.Host.Contains("localhost"))
                    {
                        appUrl = HttpContext.Current.Request.UrlReferrer.Host + ":" + HttpContext.Current.Request.UrlReferrer.Port;
                    }
                    else
                    {
                        appUrl = HttpContext.Current.Request.UrlReferrer.Host;
                    }
                }
            }
            catch (Exception ex)
            {
                if (!File.Exists(HttpContext.Current.Server.MapPath("~/Errorlog.txt")))
                    File.WriteAllLines(HttpContext.Current.Server.MapPath("~/Errorlog.txt"), new[] { ex.ToString() });
                else
                    File.AppendAllLines(HttpContext.Current.Server.MapPath("~/Errorlog.txt"), new[] { ex.ToString() });

                //SqlManager.InsertLogEntries(ex.ToString(), "ACN-GetAppUrl method", "GetAppUrl()", _companyinfo == null ? Providers.Utility.Config.AuthContext : _companyinfo.PrivateConnectionString);
            }
            return appUrl;
        }

        public Company.GetDetailsResponse GetCompanyInfo(string url)
        {
            if (url == null) throw new ArgumentNullException(url);

            var result = SqlHelper.ExecuteDataTable(Config.AuthContext, CommandType.StoredProcedure, "AdminConfiguration.GetCompanyByUrl", new SqlParameter("@Url", url));
            return ParseCompanyInfo(result);
        }

        private Company.GetDetailsResponse ParseCompanyInfo(DataTable result)
        {
            Company.GetDetailsResponse companyInfo = new Company.GetDetailsResponse();
            if (result != null && result.Rows.Count > 0)
            {
                companyInfo = new Company.GetDetailsResponse
                {
                    Url = result.Rows[0]["CompanyUrl"].ToString(),
                    CompanyID = Convert.ToInt64(result.Rows[0]["CompanyId"]),
                    CompanyName = result.Rows[0]["CompanyName"].ToString(),
                    PrivateConnectionString = result.Rows[0]["PrivateConnectionString"].ToString(),
                };
            }
            else
            {
                companyInfo.CompanyID = 0;
            }

            return companyInfo;

        }


        public ICompany Company
        {
            get
            {
                ICompany comobj = null;
                return comobj ;
            }
        }

        public IMaster Master
        {
            get
            {
                IMaster comobj = null;
                return comobj = new FMDSS.Infrastructure.ProviderDAL.Master(_companyinfo);
            }
        }


        public INOCModule NOCModule
        {
            get
            {
                INOCModule comobj = null;
                return comobj = new FMDSS.Infrastructure.ProviderDAL.NOCModuleInfra(_companyinfo);
            }
        }
    }
}
