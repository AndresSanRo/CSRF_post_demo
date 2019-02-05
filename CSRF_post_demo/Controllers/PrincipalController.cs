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
        // GET: SaleReport
        public ActionResult SaleReport()
        {
            ViewBag.SaleReport = TempData["SALE"].ToString();
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
            TempData["SALE"] = "Product bought: " + product + "€. Sent to address: " + address + ".";
            return RedirectToAction("SaleReport", "Principal");
        }        
    }
}