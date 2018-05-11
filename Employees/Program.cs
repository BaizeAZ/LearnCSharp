using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager chucky=new Manager("Chucky",50,92,10000,"233-23-2333",9000);
            chucky.GiveBonus(300);
            chucky.DisPlay();
            double cost=chucky.GetBenefitsCost();//利用委托，外部无法发现GetBenefitsCost()是BenefitsPackage类的方法
            Console.WriteLine(cost);

            //OuterClass.PublicInnerClass inner=new OuterClass.PublicInnerClass();
            //inner.publicIntNum = 7;
            SalesPerson fran=new SalesPerson("Fran",43,93,3000,"932-32-3232",31);
            fran.GiveBonus(200);
            fran.DisPlay();
            
            Console.ReadLine();
        }
    }
}
