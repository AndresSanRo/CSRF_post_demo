using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hacker.Controllers
{
    public class HomeController : Controller
    {      
        public ActionResult Hacker()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}