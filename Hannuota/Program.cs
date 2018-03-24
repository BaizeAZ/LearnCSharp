using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hannuota
{
    class Program
    {
        static void Main(string[] args)
        {
            hannuota(3, "src", "middle", "dst");
            //useful~
            var number = Math.Round(0.3333, 2);
            Console.WriteLine(number);
            Console.ReadLine();
        }

        public static void hannuota(int disc, string src, string middle, string dst)
        {
            if (disc > 0)
            {
                hannuota(disc - 1, src, dst, middle);
                Console.WriteLine("Move disc " + disc + " from " + src + " to " + dst);
                hannuota(disc - 1, middle, src, dst);
            }
        }
    }
}
