using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLibrary.Model
{
    public class EmpMeta
    {
        public int Eid { get; set; }
        public Nullable<decimal> ESal { get; set; }
        public Nullable<bool> EGen { get; set; }
        public Nullable<System.DateTime> EDOB { get; set; }
        public int Did { get; set; }
    }

    [MetadataTypeAttribute(typeof(EmpMeta))]
    public partial class Employee
    {
        private string _ename;
        public string Ename
        {
            get
            {
                return _ename;
            }
            set
            {
                if ((value == "Ali"))
                {
                    _ename = value + "salam";
                }
            }
        }
    }
}
