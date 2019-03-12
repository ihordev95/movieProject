using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team3_Project.Models;

namespace Team3_Project.Controllers
{
    public class BrowseController : Controller
    {
        // GET: Browse
        public ActionResult Browse()
        {
            int number = 10;
            return View();
        }
    }
}