using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;

namespace Team3_Project.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            DatabaseAccess db = new DatabaseAccess();
            ViewBag.Message = "Your application description page.";
            DataSet results = db.GetDataSet();
            return View(results);
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}