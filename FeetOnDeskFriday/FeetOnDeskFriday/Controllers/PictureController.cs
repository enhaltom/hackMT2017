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

        [HttpPost]
        public void Post(PostPictureModel data)
        {
            //string url = Request["Url"];
            //string comment = Request["Comment"];
            using (var db = new Context())
            {
                var picture = new Picture();
                picture.UserId = data.UserId;
                picture.URL = data.URL;
                picture.Comment = data.Comment;
                db.Pictures.Add(picture);
                db.SaveChanges();
            }
        }

    }

    public class PostPictureModel
    {
        public string URL { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
    }
}
