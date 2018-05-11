using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//只是简单地说明委托的作用
namespace SimpleDelegate
{
    //这个委托可以指向任何传入两个整数并返回一个整数的方法
    public delegate int BinaryOp(int x, int y);

    //这个类包含了BinaryOp将指向的方法
    public class SimpleMath
    {
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public  int Subtract(int x,int y)
        {
            return x - y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****");

            SimpleMath m = new SimpleMath();
            //创建一个指向SimpleMath.Add()方法的BinaryOp对象
            BinaryOp b1 = new BinaryOp(SimpleMath.Add);//指向静态方法
            //.NET委托也可以指向实例方法
            BinaryOp b2 = new BinaryOp(m.Subtract);//指向非静态方法
            DisplayDelegateInfo(b1);//这行代码的结果没有显示Type Name是因为b1委托指向静态方法，所以没有对象被引用
            DisplayDelegateInfo(b2);
            //使用委托对象间接调用Add()方法
            Console.WriteLine("10+10 is {0}", b1(10,10));//Invoke()在这里被调用了,也可显式调用Invoke(),如：b.Invoke(10,10)
            Console.ReadLine();
            
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
        
    }

}
