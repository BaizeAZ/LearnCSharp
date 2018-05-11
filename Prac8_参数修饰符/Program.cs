using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac8_参数修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //不需要给作为输出参数的本地变量赋值，定义就好了
            int answer;
            Add(90, 90, out answer);
            Console.WriteLine("90+90={0}", answer);

            

            Console.ReadLine();
             
        }
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
        static void FillTheseValues(out int a,out string b,out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }
    }
}
