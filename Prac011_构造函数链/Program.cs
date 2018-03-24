using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac011_构造函数链
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto c = new Moto(5);
            c.SetDriverName("Tina");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}.", c.drivername);

            Console.ReadLine();
        }
    }
    class Moto
    {
        public int driverIntensity;
        public string drivername;

        public Moto() { Console.WriteLine("in default ctor"); }

        public Moto(int intensity) : this(intensity, "") { Console.WriteLine("in ctor taking a int"); }
        public Moto(string name) : this(0, name) { Console.WriteLine("in ctor taking a string"); }
        public Moto(int intensity, string name)
        {
            Console.WriteLine("in master ctor");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            drivername = name;
        }
        public void SetDriverName(string name)
        {
            drivername = name;
        }
        public void PopAWheely()
        {
            Console.WriteLine("~~~~~~~~~~~~~~");
        }
        static void PrintString(string str)
        {
            Console.WriteLine("str");
        }

    }
}
