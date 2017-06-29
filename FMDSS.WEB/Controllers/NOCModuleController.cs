using FMDSS.CustomModels.Models;
using FMDSS.WEB.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FMDSS.WEB.Controllers
{
    public class NOCModuleController : Controller
    {
        // GET: NOCModule
        public ActionResult Index(NOCModel model)
        {
            if (model == null)
                model = new NOCModel();

            try
            {
                Masters repo = new Masters();
                List<Task> tasks = new List<Task>();
                tasks.Add(Task.Factory.StartNew(() =>
                  {
                      TempData["FixedLandNocTypeList"] = repo.FixedLandNocTypeList().Data.Select(i => new SelectListItem() { Text = i.Value, Value = i.Key });
                  }));
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    TempData["FixedLandPermissionTypesList"] = repo.FixedLandPermissionTypesList(null).Data.Select(i => new SelectListItem() { Text = i.Value, Value = i.Key });
                }));
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    TempData["ApplicantType"] = Comman.GetApplicantType();
                }));
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    model.PlantDetail = repo.GetPlantList().Data.Select(i => new PlantDetails { ID = Convert.ToInt32(i.Value), PlantName = i.Key }).ToList();
                    TempData["PlantDetail"] = model.PlantDetail;
                }));

                Task.WaitAll(tasks.ToArray());

            }
            catch (Exception ex)
            {

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string NOCPurpose, string NOCType, FormCollection form)
        {
            TempData.Keep("FixedLandNocTypeList");
            TempData.Keep("FixedLandPermissionTypesList");
            NOCModel model = new NOCModel();

            model.GISInfo.NOCPurpose = Convert.ToInt32(NOCPurpose);
            model.GISInfo.NOCType = Convert.ToInt32(NOCType);
            model.PlantDetail = (List<PlantDetails>)TempData["PlantDetail"];

            string aid = string.Empty;
            try
            {
                if (Convert.ToString(Session["PermissionTypeID"]) != "") { aid = Convert.ToString(Session["PermissionTypeID"]); }
                if (Convert.ToString(form["successFlag"]).ToLower() == "true")
                {
                    model.GISInfo.GISList = (List<GISInformationList>)Newtonsoft.Json.JsonConvert.DeserializeObject(form["ids"], typeof(List<GISInformationList>));
                    model.GISInfo.GISID = Convert.ToString(form["gisid"]);
                    model.GISInfo.FileName = Convert.ToString(form["filePath"]);
                    model.GISInfo.FileNameOrignal = Convert.ToString(form["originalFileName"]);
                    model.GISInfo.AreaInHecture = Convert.ToString(form["shapeArea"]);

                    #region "KML and Lat-Long"
                    if (form["locCentroid"].ToString() != "")
                    {
                        if (form["locCentroid"].ToString().Contains(","))
                        {
                            string[] locCentroid = form["locCentroid"].ToString().Split(',');
                            model.GISInfo.Lat = locCentroid[1] == "NA" ? "" : locCentroid[1];
                            model.GISInfo.Long = locCentroid[0] == "NA" ? "" : locCentroid[0];
                        }
                    }

                    #endregion
                    #region MiningPermission

                    model.GISInfo.WaterSource = form["nearbywaterbody"].ToString() == "NA" ? "N/A" : form["nearbywaterbody"].ToString();
                    model.GISInfo.NearestWaterSource = form["nearbywaterbodydistance"].ToString() == "NA" ? "N/A" : form["nearbywaterbodydistance"].ToString();
                    model.GISInfo.NearestForestSource = form["nearbyforestdistance"].ToString() == "NA" ? "N/A" : form["nearbyforestdistance"].ToString();
                    model.GISInfo.WidelifyZone = form["nearbywildlifedistance"].ToString() == "NA" ? "" : form["nearbywildlifedistance"].ToString();
                    model.GISInfo.ISAravaliHills = form["iswithinaravali"].ToString() == "NA" ? 0 : 1;
                    model.GISInfo.ISForestLand = form["iswithinforest"].ToString() == "NA" ? 0 : 1;
                    model.GISInfo.ISPlantationArea = form["iswithinplantation"].ToString() == "NA" ? 0 : 1;
                    #endregion
                }
                else
                {
                    model = new NOCModel();
                }

            }
            catch (Exception ex)
            {
                //Response.Write(ex.InnerException + "_" + ex.StackTrace);
                // new Common().ErrorLog(ex.InnerException + "_" + ex.StackTrace, actionName + "_" + controllerName, ModuleID, DateTime.Now, UserID);
            }
            return View("Index", model);
        }

        [HttpPost]
        public async Task<ActionResult> SaveNocInformation(NOCModel Model, HttpPostedFileBase RevenueRecord, HttpPostedFileBase RevenueMap, HttpPostedFileBase DetailedProjectReport)
        {
            NOCModuleRepository repo = new NOCModuleRepository();
            StringResponse response = new StringResponse();
            try
            {
                if (ModelState.IsValid)
                {
                    string FileFullName = string.Empty;
                    string FilePath = "~/DocumentsUpload/NOC_Citizen"; 
                    if (RevenueRecord != null)
                    {
                            FileFullName = DateTime.Now.Ticks + "_" + RevenueRecord.FileName;
                            Model.RevenueRecordFile = Path.Combine(FilePath, FileFullName);
                            RevenueRecord.SaveAs(Server.MapPath(FilePath + FileFullName));
                    }

                    if (RevenueMap != null)
                    {
                            FileFullName = DateTime.Now.Ticks + "_" + RevenueMap.FileName;
                            Model.RevenueMapFile = Path.Combine(FilePath, FileFullName);
                            RevenueMap.SaveAs(Server.MapPath(FilePath + FileFullName));
                    }
                    if (DetailedProjectReport != null)
                    {
                        FileFullName = DateTime.Now.Ticks + "_" + DetailedProjectReport.FileName;
                        Model.DetailedProjectReportFile = Path.Combine(FilePath, FileFullName);
                        DetailedProjectReport.SaveAs(Server.MapPath(FilePath + FileFullName));
                    }

                    response = await repo.SaveNOCByCitizen(Model);
                }

            }
            catch (Exception ex)
            {

            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}