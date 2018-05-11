using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumrator
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            if (on)
            {
                Console.WriteLine("Turnon the radio...");
            }
            else
            {
                Console.WriteLine("Turnof the radio....");
            }
        }
    }
}
