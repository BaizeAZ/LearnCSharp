using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {        
        static void Main(string[] args)
        {
            Octagon oct = new Octagon();
            IDrawToForm itform =(IDrawToForm) oct;
            itform.Draw();

            ((IDrawToPrinter)oct).Draw();

            if (oct is IDrawToMemory)
            {
                ((IDrawToMemory)oct).Draw();
            }

            Console.ReadLine();


        }
    }
}
