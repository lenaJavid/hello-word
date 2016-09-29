using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.Interface
{
    public interface IEmp
    {
        IEnumerable<Employee> GetAllEmp(int? empId);
        bool Insert(Employee emp);
        IEnumerable<Employee> GetEmpByDepId(int depId);
    }
}
