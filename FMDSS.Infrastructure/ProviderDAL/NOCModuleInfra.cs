using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMDSS.CustomModels.Models;
using FMDSS.Infrastructure.CommanModel;
using FMDSS.Interface.Interface;
using EntityCall = FMDSS.Models.Repository;

namespace FMDSS.Infrastructure.ProviderDAL
{
   public  class NOCModuleInfra:INOCModule
    {
        private readonly Company.GetDetailsResponse _Companyinformation;
        public NOCModuleInfra(Company.GetDetailsResponse companyinfo)
        {
            if (companyinfo.CompanyID == 0)
                throw new Exception("Incorrect URL. Please verify the URL and try again");
            //For DAL
            _Companyinformation = companyinfo;
        }

        #region Save NOC by Citizen
        public StringResponse SaveNOCbyCitizen(NOCModel model)
        {
            StringResponse response = new StringResponse();
            try
            {
               // var list = new EntityCall.NOCRepository(_Companyinformation).SaveNOCbyCitizen();
                if (model != null)
                {
                    string str = Newtonsoft.Json.JsonConvert.SerializeObject(model);
                    //response.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DropDownValue>>(str);
                }
                else
                {
                    throw new Exception("No Data Available in Place List");
                }
            }
            catch (Exception ex)
            {
                //var errorRequest = "authenticatedCustomerId:" + customerId;
                //response = Response.Failed(response, ex, errorRequest, MethodBase.GetCurrentMethod().Name, _companyinfo.PrivateConnectionString, _companyinfo.CompanyID);
            }

            return response;
        }
        #endregion

    }
}
