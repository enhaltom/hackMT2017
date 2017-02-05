using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeetOnDeskFriday.Models;
using FeetOnDeskFriday.Contexts;

namespace FeetOnDeskFriday.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int userId)
        {
            ViewBag.Message = "Main Feed";
            ViewBag.userId = userId;
            using (var db = new Context())
            {
                ViewBag.Pictures = db.Pictures
                    .Where(p => p.UserId == userId)
                    .OrderByDescending(p => p.Time)
                    .ToList();
            }

            return View();
        }

        //public ActionResult Index()
        //{
        //    ViewBag.Message = "Main Feed";

        //    using (var db = new Context())
        //    {
        //        ViewBag.Pictures = db.Pictures
        //            .OrderByDescending(p => p.Time)
        //            .ToList();
        //    }

        //    return View();
        //}

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
