using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.BLL
{
    public class Emp : IEmp
    {
        public IEnumerable<Employee> GetAllEmp(int? empId)
        {
            try
            {
                DLL.Emp obj = new DLL.Emp();
                return obj.GetAllEmp(empId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Insert(Employee emp)
        {
            try
            {
                if (emp != null)
                {
                    DLL.Emp employee = new DLL.Emp();
                    return employee.Insert(emp);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<Employee> GetEmpByDepId(int depId)
        {
            try
            {
                DLL.Emp obj = new DLL.Emp();
                return obj.GetEmpByDepId(depId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
