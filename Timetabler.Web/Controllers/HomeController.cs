using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Timetabler.Data;

namespace Timetabler.Web.Controllers
{
    public class HomeController : Controller
    {
        TimetablerDb _db;

        public HomeController(TimetablerDb db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
