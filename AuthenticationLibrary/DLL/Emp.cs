using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.DLL
{
    class Emp
    {
        OrganizationEntities OE = new OrganizationEntities();

        protected internal IEnumerable<Employee> GetAllEmp(int? empId)
        {
            try
            {
                IEnumerable<Employee> emps = OE.Employees.Where(x => x.Eid == empId).ToList();
                return emps;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected internal bool Insert(Employee emp)
        {
            try
            {
                OE.Employees.Add(emp);
                OE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        protected internal IEnumerable<Employee> GetEmpByDepId(int depId)
        {
            try
            {
                return OE.Employees.Where(x => x.Did == depId).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
