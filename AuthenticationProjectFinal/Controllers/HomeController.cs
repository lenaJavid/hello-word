using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationLibrary.Model;
using AuthenticationLibrary.BLL;

namespace AuthenticationProjectFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AuthenticationLibrary.BLL.Emp obj = new AuthenticationLibrary.BLL.Emp();
            Employee emp = new Employee();
            emp.Ename = "Ali";
            emp.ESal = 1200;
            emp.EGen = false;
            emp.Did = 1;
            bool result = obj.Insert(emp);
            return View();
            //kihjiuhi
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}