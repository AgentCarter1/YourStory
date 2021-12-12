using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Odevi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            YourStory.BusinessLayer.Test test = new YourStory.BusinessLayer.Test();
            // test.Insert();
            //test.Update();
            //test.Delete();
            test.CommentTest();
            return View();
        }

        
    }
}