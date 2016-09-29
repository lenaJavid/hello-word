using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLibrary.ModelMeta
{
    public class EmpMeta
    {
        private string _eName;
        public int Eid { get; set; }
        public string Ename 
        {
            get { return _eName; }
            set { _eName = value + "Salam"; }
        }
        public Nullable<decimal> ESal { get; set; }
        public Nullable<bool> EGen { get; set; }
        public Nullable<System.DateTime> EDOB { get; set; }
        public int Did { get; set; }
    }

    [MetadataTypeAttribute(typeof(EmpMeta))]
    public partial class tbl_Emp
    {

    }
}
