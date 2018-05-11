using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac9_参数修饰符ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before:{0},{1}", str1, str2);
            SwapStrings(ref str1,ref str2);
            Console.WriteLine("After:{0},{1}", str1, str2);
            Console.ReadLine();
        }
        public static void SwapStrings(ref string s1,ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
    }
}
