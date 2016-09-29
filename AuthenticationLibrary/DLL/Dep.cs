using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.DLL
{
    class Dep
    {
        OrganizationEntities OE = new OrganizationEntities();

        protected internal IEnumerable<Department> GetAllDep(int? depId)
        {
            try
            {
                IEnumerable<Department> deps = OE.Departments.Where(x => x.Did == depId).ToList();
                return deps;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected internal bool Insert(Department dep)
        {
            try
            {
                OE.Departments.Add(dep);
                OE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
