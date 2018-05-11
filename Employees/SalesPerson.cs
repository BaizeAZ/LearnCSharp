using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson:Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numberOfSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numberOfSales;
        }

        public sealed override void GiveBonus(float amount)//密封防止PTSalesPerson类重写和调用
        {
            int salesBonus = 0;
            if (SalesNumber>=0 && SalesNumber<=100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber>=101 && SalesNumber<=200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
            }
            base.GiveBonus(amount*salesBonus);
        }

        public override void DisPlay()
        {
            base.DisPlay();
            Console.WriteLine("Number of Sales:{0}",SalesNumber);
        }
    }
}
