using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");

            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            Func<int, int, int> funcTarget1 = new Func<int, int, int>(Add);
            //int result = funcTarget1.Invoke(40, 40);
            Console.WriteLine("40+40={0}", funcTarget1(40, 40));

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(sumToString);
            string sum = funcTarget2.Invoke(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static void DisplayMessage(string msg,ConsoleColor txtColor,int printCount)
        {
            //设置命令行文本的颜色
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            //重置颜色
            Console.ForegroundColor = previous;
        }
        static int Add(int x,int y)
        {
            return x + y;
        }
        static string sumToString(int x,int y)
        {
            return (x + y).ToString();
        }
    }
}
