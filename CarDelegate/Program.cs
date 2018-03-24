using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);
            
            c1.RegisterWithCarEngine(new Car.CarEnginHandler(OnCarEngineEvent));
            //c1.RegisterWithCarEngine(new Car.CarEnginHandler(OnCarEngineEvent2));

            //先绑定委托对象，稍后再注销.和上面不同的是，这里创建了这个委托类型的对象，并保存在本地变量中，这样就可以使用该对象在后面注销通知
            Car.CarEnginHandler handler2 = new Car.CarEnginHandler(OnCarEngineEvent2);
            
            c1.RegisterWithCarEngine(handler2);

            Console.WriteLine("***** Speed Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
                //Console.ReadLine();
            }
            //注销第二个处理程序
            c1.UnRegisterWithCarEngine(handler2);


            //看不到大写消息了
            Console.WriteLine("***** Speed Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
                //Console.ReadLine();
            }

            Console.ReadLine();
        }
        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("*************************************\n");
        }
        private static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
