using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            Person per1 = new Person() { F_Name = "JJ", L_Name = "H", Age = 22 };
            Person per2 = new Person() { F_Name = "My", L_Name = "Girl", Age = 21 };

            MyGenericMethods.Swap<int>(ref a,ref b);
            MyGenericMethods.Swap<Person>(ref per1,ref per2);

            Console.WriteLine("a: {0} b: {1}",a,b);
            Console.WriteLine("per1: {0}",per1);
            Console.WriteLine("per2: {0}", per2);

            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<Person>();
            Console.ReadLine();
        }
    }
}
