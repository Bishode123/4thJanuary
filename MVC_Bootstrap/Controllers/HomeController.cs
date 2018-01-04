using MVC_Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Home
        [HttpPost]
        public ActionResult Index(Employee e1)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }
            return View(e1);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}