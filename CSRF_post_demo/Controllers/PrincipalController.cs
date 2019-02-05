using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSRF_post_demo.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }
        // GET: Buy
        public ActionResult Buy()
        {
            return View();
        }
        // POST: Buy
        [HttpPost]
        public ActionResult Buy(string product, string address)
        {
            return View();
        }
    }
}