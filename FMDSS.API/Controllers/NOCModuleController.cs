using FMDSS.CustomModels.Models;
using FMDSS.Interface;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FMDSS.API.Controllers
{
    //[Authorize]
    public class NOCModuleController : ApiController
    {
        private readonly IRequestManager _requestManager;
        public NOCModuleController(IRequestManager requestManager)
        {
            _requestManager = requestManager;
        }

        [HttpGet]
        [Route("api/NOCModule/GetPlantList")]
        public DropDownResponse GetPlantList()
        {
            DropDownResponse response = new DropDownResponse();
            try
            {
                response = _requestManager.Master.GetPlantList();
            }
            catch (Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Plant found");
            }
            return response;
        }

        [HttpPost]
        [Route("api/NOCModule/SaveNOCByCitizen")]
        public StringResponse SaveNOCByCitizen([FromBody]NOCModel model)
        {
            StringResponse response = new StringResponse();
            try
            {
                response = _requestManager.NOCModule.SaveNOCbyCitizen(model);
            }
            catch (Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Plant found");
            }
            return response;
        }


    }
}
