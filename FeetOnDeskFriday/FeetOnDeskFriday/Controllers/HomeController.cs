using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeetOnDeskFriday.Models;

namespace FeetOnDeskFriday.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Main Feed";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are team 14 from HackMT2017";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please tell us what you think";

            return View();
        }
    }
}
