using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGroupConversion
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Method Group Conversion *****\n");

            Car c1 = new Car();
            //方法组转换，调用以委托作为参数的方法时直接提供方法的名称，而不用创建委托对象
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("***** Speed Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            c1.UnRegisterWithCarEngine(CallMeHere);

            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadLine();
        }
        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }
    }
}
