using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace Prac
{
   
    class Program
    {
        static void Main(string[] args)
        {

            ushort a = 2;
            GetUserData();
            ShowEnvironmentDetails();
            Console.WriteLine(a);
            Console.ReadLine();
            
        }

        private static void GetUserData()
        {
            Console.WriteLine("Please enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter yourage: ");
            string userage = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor=ConsoleColor.DarkCyan;

            Console.WriteLine("Hello {0}! You are {1:C} years old.",username,userage);

            Console.ForegroundColor = prevColor;
        }

        private static void ShowEnvironmentDetails()
        {
            foreach (var drive in Environment.GetLogicalDrives() )
            {
                Console.WriteLine("Drive:{0}",drive);
            }
            Console.WriteLine("OS:{0}",Environment.OSVersion);
            Console.WriteLine("Number of processors:{0}",Environment.ProcessorCount);
            Console.WriteLine(".NET Version:{0}",Environment.Version);
        }
    }
}
