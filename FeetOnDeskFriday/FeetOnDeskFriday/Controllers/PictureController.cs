using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeetOnDeskFriday.Contexts;

namespace FeetOnDeskFriday.Controllers
{
    public class PictureController : Controller
    {
        //
        // GET: /Picture/

        public ActionResult Index()
        {
            return View();
        }

        public List<string> ListURLs()
        {
            using (var db = new Context())
            {
                return db.Pictures.Select(p => p.URL).ToList<string>();
            }
        }

    }
}
