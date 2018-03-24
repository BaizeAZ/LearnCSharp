using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac4_StringsAndStringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunc();
            FunWithStringBuilders();
            Console.ReadLine();
        }

        private static void FunWithStringBuilders()
        {
            //StringBuilder的独特之处在于，当调用这个类型的成员时，都是直接修改对象内部的字符数据，而不是获取修改后格式的数据副本
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb=new StringBuilder("*** Fantastic Games ***",256);
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowing");
            sb.AppendLine("Deus Ex"+"2");
            sb.AppendLine("System Shock");
            
            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.",sb.Length);
            Console.WriteLine();
        }

        private static void BasicStringFunc()
        {
            string firstname = "Freddy";
            Console.WriteLine("Value of firstname:{0}",firstname);
            Console.WriteLine("firstname has {0} charactor",firstname.Length);
            Console.WriteLine("firstname in uppercase:{0}",firstname.ToUpper());
            Console.WriteLine("firstname contains the letter y?: {0}",firstname.Contains("y"));
            Console.WriteLine("firstname after replace: {0}",firstname.Replace("dy"," "));

            Console.WriteLine(@"C:\MyApp\bin\Debug");
            //使用逐字字符串，空格被保留
            string myLongString = @"This is a very
                        very
                                very    
                                        longstring";
            Console.WriteLine(myLongString);
            //通过重复“标记向一个字面量字符串插入一个双引号
            Console.WriteLine(@"Cerebus said ""Darry!  Pret-ty sun-sets"" ");

            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1={0}",s1);
            Console.WriteLine("s2={0}",s2);
            Console.WriteLine();
            //测试字符串的相等性
            Console.WriteLine("s1==s2:{0}",s1==s2);
            Console.WriteLine("s1==Hello!:{0}",s1=="Hello!");
            Console.WriteLine("s1==HELLO!:{0}", s1 == "HELLO!");
            Console.WriteLine("s1==hello!:{0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2):{0}", s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2):{0}","Yo!".Equals(s2));
            Console.WriteLine();
            //String的数据类型是引用类型，但相等性操作符已经被重新定义为比较字符串对象的值，而不是内存中他们引用的对象           
        }
    }
}
