using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        // Controller classes need to be public
        // Controllers are coordinators 
        // Presenting Content is the job for a view 
        
        // Action Method
        public ActionResult Detail()
        {
            return View();
        }
    }
}