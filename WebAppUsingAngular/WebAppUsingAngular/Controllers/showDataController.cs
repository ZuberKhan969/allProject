using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppUsingAngular.Models;

namespace WebAppUsingAngular.Controllers
{
    public class showDataController : Controller
    {
        // GET: showData
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData() {
           
            EmployeeDataImageEntities db = new EmployeeDataImageEntities();
            var data = db.Emaployees.ToList();
            //Emaployee em = new Emaployee();
           
            List<EmployeeModel> dm = new List<EmployeeModel>();
            foreach (var item in data)
            {

                EmployeeModel em = new EmployeeModel();
                string inageBase64 = Convert.ToBase64String(item.ProfileImage);
                string imageUrl = string.Format("data:image/jpeg;base64,{0}", inageBase64);
                em.EmployeeId = item.EmployeeId;
                em.Name = item.Name;
                em.Image = item.Image;
                em.ProfileImage = imageUrl;
                dm.Add(em);
            }
            
            return Json(dm, JsonRequestBehavior.AllowGet);

        }
    }
}