using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSRF_post_demo.Controllers
{
    public class VulnerableController : Controller
    {
        // GET: Vulnerable
        public ActionResult Index()
        {
            return View();
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
    }
}