using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****\n");
            Car c1 = new Car("SlugBug",100,10);
            //利用EventArgs<T>简化后,改变创建对象的类型，不再是自定义的委托类型
            //c1.AboutToBlow +=CarIsAlmostDoomed;方法组转换
            c1.AboutToBlow += CarIsAlmostDoomed;
            
            c1.AboutToBlow += delegate //匿名方法/未命名方法（这里C#内联处理事件，通过直接把一段代码语句赋值给事件）
            {
                Console.WriteLine("Going too fast!!!");
            };//匿名方法最后一个大括号必须要分号结尾

            c1.AboutToBlow += delegate (object sender, CarEventArgs e)//匿名方法带参数列表
            {
                if (sender is Car)
                {
                    Car c = (Car)sender;
                    Console.WriteLine("{0} say: {1}",c.PetName,e.msg);
                }                
            };

            EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarExploded);
            c1.Exploded += d;

            Console.WriteLine("***** Speed Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            c1.Exploded -= d;
            Console.WriteLine("\n***** Speed Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();
        }

        //使用匿名方法节省了代码，不需要自己去完全地手工定义一个只是用来被委托调用的方法
        //public static void CarAboutToBlow(object sender,CarEventArgs e)
        //{
        //    if (sender is Car)
        //    {
        //        Car c = (Car)sender;
        //        Console.WriteLine("{0} say: {1}", c.PetName, e.msg);
        //    }          
        //}
        public static void CarIsAlmostDoomed(object sender,CarEventArgs e)
        {
            if (sender is Car)
            {
                Car c = (Car)sender;
                Console.WriteLine("=> Critical Message from {0}: {1}", c.PetName, e.msg);
            }          
        }
        public static void CarExploded(object sender, CarEventArgs e)
        {
            if (sender is Car)
            {
                Car c = (Car)sender;
                Console.WriteLine("{0} say: {1}", c.PetName, e.msg);
            }
        }
    }
}
