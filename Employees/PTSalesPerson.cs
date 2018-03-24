using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //兼职销售员，不必再派生分支
    //密封类，类图分支在此阻断
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson()
        {
        }

        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numberOfOpts)
            : base(fullName, age, empID, currPay, ssn, numberOfOpts)
        {
            //假设其它成员......
        }
        
    }
}
