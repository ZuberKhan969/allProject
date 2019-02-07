using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Home
        public ActionResult Index()
        {
            DataContext db = new DataContext();
            var data = db.Employees.Count();

            return View(data);
        }
    }
}