using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoLayoutSetting.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getMessage() {
            var Mess = "This is message";
            return Json(Mess, JsonRequestBehavior.AllowGet);
        }
    }
}