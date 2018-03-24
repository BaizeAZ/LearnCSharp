using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager:Employee
    {
        public int StockOptions { get; set; }

        public Manager(string _fullName, int _age, int _empID, float _currPay, string _ssn, int _numberOfOpts)
            : base(_fullName, _age, _empID, _currPay, _ssn)
        {
            StockOptions = _numberOfOpts;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r=new Random();
            StockOptions += r.Next(500);
        }

        public override void DisPlay()
        {
            base.DisPlay();
            Console.WriteLine("Number of Stock Options:{0}",StockOptions);
        }
    }
}
