using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseFormStrings();
            Console.ReadLine();
        }

        static void ParseFormStrings()
        {
            bool number;
            bool b = bool.TryParse("false", out number);
            Console.WriteLine("Value of b:{0}",number);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d:{0}",d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i:{0}",i);
            char c = char.Parse("w");
            Console.WriteLine("Value of c:{0}",c);
            Console.WriteLine();
        }
    }
}
