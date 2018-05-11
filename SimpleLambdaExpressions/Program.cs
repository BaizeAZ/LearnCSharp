using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //TraditionalDelegateSyntax();
            LambdaExpressionSyntax();
            Console.ReadLine();
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            ////使用传统委托语法调用FindAll()
            //Predicate<int> callback = new Predicate<int>(IsEventNumber);
            List<int> eventNumbers = list.FindAll(delegate(int i) { return (i % 2) == 0; });//匿名方法简化

            Console.WriteLine("Here are your even numbers:");
            foreach (int item in eventNumbers)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
        }

        //static bool IsEventNumber(int i)
        //{
        //    //判断是否是偶数
        //    return (i % 2) == 0;
        //}
        static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //(1)
            //使用Lambda表达式简化匿名方法,它可以应用于任何匿名方法或者强类型委托可以应用的场合
            //以下Lambda表达式被编译器翻译为使用Predicate<T>的标准匿名方法而已（可以使用ildasm.exe验证）
            List<int> eventNumbers = list.FindAll(i => (i % 2) == 0);//这里参数i是隐式类型化的(这里是int),也可以为显示类型化  list.FindAll((int i) => (i%2) == 0);
  
            //(2)
            //使用多个语句处理参数
            List<int> eventNumbers2 = list.FindAll((i) =>
             {
                 Console.WriteLine("value of i is currently: {0}",i);
                 bool isEven = ((i % 2) == 0);
                 return isEven;
             });

            Console.WriteLine("(1)Here are your even numbers:");
            foreach (int item in eventNumbers)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            Console.WriteLine("(2)Here are your even numbers:");
            foreach (int item in eventNumbers2)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
        }
    }
}
