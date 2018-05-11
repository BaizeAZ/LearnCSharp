using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3_DateTime_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDatesAndTimes();
            Console.ReadLine();
        }

        private static void UseDatesAndTimes()
        {
            DateTime dt=new DateTime(2016,2,23);
            Console.WriteLine("Time day of {0} is {1}",dt.Date,dt.DayOfWeek);
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight saving:{0}", dt.IsDaylightSavingTime());

            TimeSpan ts=new TimeSpan(4,30,0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
        }
    }
}
