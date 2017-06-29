

namespace FMDSS.WEB.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using log4net;
    using System.Configuration;
    using System.Web.Routing;
    using MongoDB.Driver;
    using App_Start;

    /// <summary>
    /// Class BaseController
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// Called before the action method is invoked.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
       
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.HttpMethod == "GET")
            {

                
            }

            string IPAddress = this.Request.UserHostAddress;// GetIPAddress(filterContext.HttpContext.Request);
            base.OnActionExecuting(filterContext);
            string actionParam = string.Empty;
            foreach (var param in filterContext.ActionParameters)
            {
              //  actionParam += param.Key + "=" + Encryption.decrypt(Convert.ToString(param.Value));
            }

            ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            log.Info(string.Format("Start: Action={0} Controller={1} Param={2} IP Address={3}", filterContext.ActionDescriptor.ActionName, filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, IPAddress, string.Join(",", actionParam)));



            
            
            MongoClient client = new MongoClient("mongodb://10.68.106.71:27017");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("db_FMDSS");

            var collection = db.GetCollection<UserLogs>("UserLogs");

            UserLogs logs = new App_Start.UserLogs();
            logs.ActionName = filterContext.ActionDescriptor.ActionName;
            logs.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            logs.DateTime = DateTime.Now.ToString();
            logs.IPAddress = IPAddress;
            logs.ssoId = "amit17rajput";
            logs.BrowserName = "";

            var browser = HttpContext.Request.Browser;
            logs.Type = browser.Type;
            logs.Name = browser.Browser;
            logs.Version = browser.Version;


            collection.Save(logs);

            /////Insert logs in Database


            //  oLogs.SaveUserLogs(filterContext.ActionDescriptor.ActionName, DateTime.Now, "Start", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName + "?" + string.Join(",", actionParam), "", Convert.ToString(Session["SSOID"]), IPAddress);


            HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
            HttpContext.Response.Cache.SetValidUntilExpires(false);
            HttpContext.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
            HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Response.Cache.SetNoStore();
        }

        public static string GetIPAddress(HttpRequestBase request)
        {
            string ip;
            try
            {
                ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (!string.IsNullOrEmpty(ip))
                {
                    if (ip.IndexOf(",") > 0)
                    {
                        string[] ipRange = ip.Split(',');
                        int le = ipRange.Length - 1;
                        ip = ipRange[le];
                    }
                }
                else
                {
                    ip = request.UserHostAddress;
                }
            }
            catch { ip = null; }

            return ip;
        }

        /// <summary>
        /// Called after the action method is invoked.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            log.Info(string.Format("End: Action={0} Controller={1}", filterContext.ActionDescriptor.ActionName, filterContext.ActionDescriptor.ControllerDescriptor.ControllerName));
            ///Database Log
            //oLogs.SaveUserLogs(filterContext.ActionDescriptor.ActionName, DateTime.Now, "End", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName, "", Convert.ToString(Session["SSOID"]));
        }

        /// <summary>
        /// Renders the partial view to string.
        /// </summary>
        /// <param name="viewName">Name of the view.</param>
        /// <param name="model">The model.</param>
        /// <returns>returns the view as html string.</returns>
        protected string RenderPartialViewToString(string viewName, object model)
        {
            if (string.IsNullOrEmpty(viewName))
            {
                viewName = ControllerContext.RouteData.GetRequiredString("action");
            }

            ViewData.Model = model;

            using (StringWriter sw = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
