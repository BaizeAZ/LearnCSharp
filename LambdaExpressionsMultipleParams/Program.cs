using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LambdaExpressionsMultipleParams
{
    public delegate string VerySimpleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            //使用Lambda表达式与有多个参数的委托交互
            m.SetMathHandler((msg,result)=>// (string msg,int result)=>
            {
                Console.WriteLine("Message: {0},Result: {1}",msg,result);
            });
            m.Add(10,10);
            //与无参数的委托交互可以这样
            VerySimpleDelegate d = new VerySimpleDelegate(() => { return "Enjoy your string!"; });
            Console.WriteLine(d.Invoke());

            Console.ReadLine();
        }
    }
}
