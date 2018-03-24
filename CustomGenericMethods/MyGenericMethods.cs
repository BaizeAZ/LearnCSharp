using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    public class MyGenericMethods
    {
        //可以处理任何类型的交换而又不会造成非泛型所产生的问题，拆、装箱，类型安全，显示转换等。
        public static void Swap<T>(ref T a,ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }
        public static void DisplayBaseClass<T>()
        {
            Console.WriteLine("Base class of {0} is: {1}", typeof(T), typeof(T).BaseType);

        }
    }
}
