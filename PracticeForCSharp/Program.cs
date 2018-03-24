using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 按值传递引用类型
/// </summary>
namespace _001_按值传递引用类型
{
    class Program
    {
        public class MyInfo
        {
            public string MyName { get; set; }
            public int MyAge { get; set; }

            public MyInfo(string _name,int _age)
            {
                MyName = _name;
                MyAge = _age;
            }

            public void Display()
            {
                Console.WriteLine("Name:{0} Age:{1}",MyName, MyAge);
            }
        }

        public static void Send(MyInfo info)
        {
            info.MyAge = 30;
            info = new MyInfo("CC", 22);
            info.Display();
        }

        static void Main(string[] args)
        {
            MyInfo info1 = new MyInfo("JJ", 24);
            info1.Display();
            Send(info1);
            info1.Display();

            Console.ReadLine();
        }
    }
}
