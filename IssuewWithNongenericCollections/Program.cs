using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuewWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            object o = a;

            try
            {
                long b = (long)o;
            }
            catch (InvalidCastException ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
