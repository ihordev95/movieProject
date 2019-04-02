using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team3_Project.Controllers
{
    public class AvailableListViewController : Controller
    {
        // GET: AvailableListView
        public ActionResult AvailableLists()
        {
            return View();
        }
    }
}