using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac7_枚举类型
{
    enum Emptype:byte
    {
        Manager=10,
        Grunt=1,
        Contractor=100,
        VicePresident=9
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums ****");
            Emptype emp=Emptype.Contractor;
            AskForBonus(emp);

            Console.WriteLine("EmpType uses a {0} for storage",Enum.GetUnderlyingType(typeof(Emptype)));

            Console.ReadLine();
        }

        private static void AskForBonus(Emptype e)
        {
            switch (e)
            {
                case Emptype.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case Emptype.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case Emptype.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case Emptype.VicePresident:
                    Console.WriteLine("VERY GOOD,Sir!");
                    break;
            }
        }
    }
}
