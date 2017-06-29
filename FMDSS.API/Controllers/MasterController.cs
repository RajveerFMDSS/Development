using FMDSS.CustomModels.Models;
using FMDSS.Interface;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FMDSS.API.Controllers
{
    //[Authorize]
    public class MasterController : ApiController
    {
        private readonly IRequestManager _requestManager;
        public MasterController(IRequestManager requestManager)
        {
            _requestManager = requestManager;
        }

        public string test()
        {
            return "dfsdf";
        }



        #region GIS Master
        [HttpGet]
        [Route("api/Master/FixedLandNocTypeList")]
        public DropDownResponse FixedLandNocTypeList()
        {
            DropDownResponse response = new DropDownResponse();
            try
            {
                response = _requestManager.Master.GetFixedLandNocTypeList();
            }
            catch (Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Place found");
            }
            return response;
        }

        [HttpGet]
        [Route("api/Master/FixedLandPermissionTypesList")]
        public DropDownResponse FixedLandPermissionTypesList([FromUri]int? EmitraServiceID)
        {
            DropDownResponse response = new DropDownResponse();
            try
            {
                response = _requestManager.Master.GetFixedLandPermissionTypesList(EmitraServiceID);
            }
            catch (Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Place found");
            }
            return response;
        }
        #endregion

        [HttpGet]
        [Route("api/Master/GetPlaceList")]
        public MasterPlaceModelResponse PlaceList()
        {
            MasterPlaceModelResponse response = new MasterPlaceModelResponse();
            try
            {
                response = _requestManager.Master.GetMasterPlaceList();
            }
            catch (Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Place found");
            }
            return response;
        }
    }
}
