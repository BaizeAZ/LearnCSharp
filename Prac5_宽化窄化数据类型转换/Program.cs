using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac5_宽化窄化数据类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 9, num2 = 10;
            Console.WriteLine("{0}+{1}={2}",num1,num2,Add(num1,num2));
            NarrowingAttempt();
            Console.ReadLine();
        }
        //传参时short因为范围比int小所以便隐式宽化为int
        //宽化用于定义隐式向上转换，并且不会丢失数据
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 300;
            myByte = (byte)myInt;//通知编辑器我们想要处理窄化运算引起的可能的数据丢失，我们必须进行显式强制转换。
            Console.WriteLine(myByte);//发生上溢，300-256=44
        }

    }
}
