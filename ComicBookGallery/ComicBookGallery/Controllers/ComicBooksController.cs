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

        // Action Method
        public string Detail() {
            return "Hello from the ComicBookController";
        }
    }
}