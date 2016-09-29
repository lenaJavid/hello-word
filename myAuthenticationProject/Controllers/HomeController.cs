using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myAuthenticationProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //comment
            //95873495837
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
