using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.BLL
{
    public class Dep : IDep
    {
        public IEnumerable<Department> GetAllDep(int? depId)
        {
            try
            {
                DLL.Dep obj = new DLL.Dep();
                return obj.GetAllDep(depId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Insert(Department dep)
        {
            try
            {
                if (dep != null)
                {
                    DLL.Dep department = new DLL.Dep();
                    return department.Insert(dep);
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
