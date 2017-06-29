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
    public class Master : IMaster
    {
        private readonly Company.GetDetailsResponse _Companyinformation;
        public Master(Company.GetDetailsResponse companyinfo)
        {
            if (companyinfo.CompanyID == 0)
                throw new Exception("Incorrect URL. Please verify the URL and try again");
            //For DAL
            _Companyinformation = companyinfo;
        }

        #region GIS Master
        public DropDownResponse GetFixedLandNocTypeList()
        {
            DropDownResponse response = new DropDownResponse();
            try
            {
                var list = new EntityCall.MasterRepository(_Companyinformation).GetFixedLandNocTypeList();
                if (list != null)
                {
                    string str = Newtonsoft.Json.JsonConvert.SerializeObject(list);
                    response.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DropDownValue>>(str);
                    //foreach(var itm in list)
                    // {

                    //    // DropDownValue val = new DropDownValue();
                    //     //val.Value = Convert.ToString(itm.NocTypeName);
                    //     //val.Key = Convert.ToString(itm.NocTypeid);

                    //     response.Data.Add(val);
                    // }
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
        public DropDownResponse GetFixedLandPermissionTypesList(int? EmitraServiceID)
        {
            DropDownResponse response = new DropDownResponse();
            try
            {
                var list = new EntityCall.MasterRepository(_Companyinformation).GetFixedLandPermissionTypesList(EmitraServiceID);
                if (list != null)
                {
                    string str = Newtonsoft.Json.JsonConvert.SerializeObject(list);
                    response.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DropDownValue>>(str);
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

        #region Get Plant List
        public DropDownResponse GetPlantList()
        {
            DropDownResponse response = new DropDownResponse();
            try
            {
                var list = new EntityCall.MasterRepository(_Companyinformation).GetPlantList();
                if (list != null)
                {
                    string str = Newtonsoft.Json.JsonConvert.SerializeObject(list);
                    response.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DropDownValue>>(str);
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
        public MasterPlaceModelResponse GetMasterPlaceList()
        {
            MasterPlaceModelResponse response = new MasterPlaceModelResponse();
            try
            {
                var list = new EntityCall.MasterRepository(_Companyinformation).GetPlaceList();
                if (list != null)
                {
                    string str = Newtonsoft.Json.JsonConvert.SerializeObject(list);
                    response.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Master_TblMstPlaceModel>>(str);
                }
                else
                {
                    throw new Exception("No Data Available in Place List");
                }
                //DataTable dt = new SQLDAL.Master(_Companyinformation).GetMasterDistricts(_Companyinformation.PrivateConnectionString, _Companyinformation.CompanyID, string.Empty);
                //if (dt.IsValid())
                //{
                //    //Logic Put Here for Conversion or Mapping
                //    response.Data = dt;
                //}
            }
            catch (Exception ex)
            {
                //var errorRequest = "authenticatedCustomerId:" + customerId;
                //response = Response.Failed(response, ex, errorRequest, MethodBase.GetCurrentMethod().Name, _companyinfo.PrivateConnectionString, _companyinfo.CompanyID);
            }
            return response;
        }
    }
}
