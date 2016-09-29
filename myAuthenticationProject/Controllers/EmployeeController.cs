using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using myAuthenticationProject.Models;

namespace myAuthenticationProject.Controllers
{
    public class EmployeeController : ApiController
    {
        private OrganizationEntities db = new OrganizationEntities();

        /// <summary>
        /// GET api/Employee
        /// </summary>
        /// <returns></returns>
        public IEnumerable<tbl_Emp> GetCities()
        {
            return db.tbl_Emp.AsEnumerable();
        }


        /// <summary>
        /// POST api/Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public IEnumerable<tbl_Emp> AddEmployee(tbl_Emp employee)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Emp.Add(employee);
                db.SaveChanges();

                return db.tbl_Emp.AsEnumerable();
            }
            else
            {
                return null;
            }
        }
    }
}
