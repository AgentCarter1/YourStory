using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourStory.BusinessLayer;
using YourStory.Entities;

namespace Web_Odevi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {          
            return View();
        }

        
    }
}