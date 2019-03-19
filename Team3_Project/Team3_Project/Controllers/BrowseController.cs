using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team3_Project.Controllers
{
    public class BrowseController : Controller
    {
        // GET: Browse
        public ActionResult BrowseMovies()
        {
            return View();
        }
    }
}