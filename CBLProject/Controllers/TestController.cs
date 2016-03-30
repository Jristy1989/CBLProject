using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBLProject.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            NameValueCollection nameValueCollection = System.Web.HttpContext.Current.Request.QueryString;
            var parm1 = nameValueCollection["dev"];
            return View();
        }

        public ActionResult DevForm()
        {
            return View();
        }
    }
}