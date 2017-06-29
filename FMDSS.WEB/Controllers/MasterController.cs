using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FMDSS.WEB.Repository;
using FMDSS.CustomModels.Models;
namespace FMDSS.WEB.Controllers
{
    public class MasterController : Controller
    {

        public ActionResult PlaceList()
        {
            MasterPlaceModelResponse model = new MasterPlaceModelResponse();
            try
            {
                Masters master = new Masters();
                model = master.PlaceList();
            }
            catch (Exception ex)
            {

            }
            return View(model);
        }

        // GET: Master
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetDistrictsList()
        {
            return View();
        }

        public ActionResult GetPlacesList()
        {
            MasterPlaceModelResponse model = new MasterPlaceModelResponse();
            try
            {
                Masters master = new Masters();
                model = master.PlaceList();
            }
            catch (Exception ex)
            {

            }
            return View(model);
        }

        public ActionResult AddPlaces()
        {
            return View();
        }
       
    }
}