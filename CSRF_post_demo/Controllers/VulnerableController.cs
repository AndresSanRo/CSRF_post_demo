using CSRF_post_demo.Models;
using CSRF_post_demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSRF_post_demo.Controllers
{
    public class VulnerableController : Controller
    {
        RepositoryUser Repo;
        public VulnerableController()
        {
            Repo = new RepositoryUser();
        }
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
        // POST: Login
        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            User currentUser = Repo.ExistsUser(user.ToUpper(), password.ToUpper());
            if (currentUser != null)            
                Session["USER"] = currentUser.Name;
                        
            return RedirectToAction("Index", "Principal");
        }
    }
}