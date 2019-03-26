using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsAdmin
{
    public class Packages
    {
        public int PkgId{ get; set; }
        public string PkgName { get; set; }
        public string PkgSartDate { get; set; }
        public string PkgEndDate { get; set; }
        public string PkgDescription { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommition{ get; set; }// Allow null in Decimal 

        public override string ToString()
        {
            return "Package Name:"+ PkgName+ "Package Description"+PkgDescription;
        }

    }
}
