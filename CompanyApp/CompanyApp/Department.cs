using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp
{
    public class Department
    {
        public string DName { get; set; }
        public int DNumber { get; set; }
        public int MgrSSN { get; set; }
        public DateTime MgrStartDate { get; set; }
        public int EmpCount { get; set; }


        public string FullInfo
        {
            get
            {
                return $"{ DName } ({EmpCount})";
            }
        }

    }

}
