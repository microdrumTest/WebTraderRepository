﻿using System.Web.Mvc;

namespace WebTrader.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            return View();
        }
    }
}
