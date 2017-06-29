using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMDSS.WEB.Repository
{
    public static class Comman
    {
        public static IList<SelectListItem> GetApplicantType()
        {
            IList<SelectListItem> _result = new List<SelectListItem>();
            _result.Add(new SelectListItem { Value = "1", Text = "Individual" });
            _result.Add(new SelectListItem { Value = "2", Text = "Organization" });
            return _result;
        }
    }
}