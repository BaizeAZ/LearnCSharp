using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_练习
{
    class Program
    {     
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle("adadadadad", 4, 5, 6, 7);
            Rectangle r2 = r1;
            r2.rectBottom = 10;
            r2.rectInfo.stringInfo = "qeqeqeqeqe";
            r1.display();
            r2.display();
            Console.ReadLine(); 
        }
     
    }
}
