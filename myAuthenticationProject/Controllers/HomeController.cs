using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationLibrary.Model;
using AuthenticationLibrary.BLL;

namespace myAuthenticationProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AuthenticationLibrary.BLL.Emp obj = new AuthenticationLibrary.BLL.Emp();
            IEnumerable<Employee> result = obj.GetAllEmp(null);

            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
