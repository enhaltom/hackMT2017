using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeetOnDeskFriday.Contexts;
using System.Web.Http;

namespace FeetOnDeskFriday.Controllers
{
    public class PictureController : ApiController
    {
        //
        // GET: /Picture/

        public void Post(PostPictureModel data)
        {
            
            using (var db = new Context())
            {
                var picture = new Picture();
                picture.UserId = data.UserId;
                picture.URL = data.URL;
                picture.Comment = data.Comment;
                picture.Time = DateTime.Now;
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
