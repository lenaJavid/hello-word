using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AuthenticationLibrary.Model;

namespace myAuthenticationProject.Controllers
{
    public class EmployeeController : ApiController
    {
        private OrganizationEntities db = new OrganizationEntities();

        /// <summary>
        /// GET api/Employee
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetCities()
        {
            return db.Employees.AsEnumerable();
        }


        /// <summary>
        /// POST api/Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public IEnumerable<Employee> AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();

                return db.Employees.AsEnumerable();
            }
            else
            {
                return null;
            }
        }
    }
}
