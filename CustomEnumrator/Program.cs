using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Carage carLot = new Carage();
            
            foreach (Car item in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",item.PetName,item.CurrentSpeed);
            }

            IEnumerator i = carLot.GetEnumerator();
            i.MoveNext();
            i.MoveNext();      
            Car myCar = (Car)i.Current;
            Console.WriteLine("{0} is going {1} MPH",myCar.PetName,myCar.CurrentSpeed);

            Console.ReadLine();
        }
    }
}
