using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hacker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HackerVulnerableCSRF()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult HackerNotVulnerableCSRF()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}