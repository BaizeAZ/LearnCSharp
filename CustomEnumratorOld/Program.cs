using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumratorOld
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new IterationSample(new object[] { 'a', 'b', 'c', 'd', 'e' }, 3);
            foreach (var item in c)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
