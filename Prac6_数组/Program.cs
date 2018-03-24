using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac6_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            RectMultidimensionalArray();
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        private static void SystemArrayFunctionality()
        {
            Console.WriteLine("=>Woking with System.Array.");
            string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sister of Mercy"};

            Console.WriteLine("-> Here is the Array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i]+",");
            }
            Console.WriteLine("\n");

            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i]+",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands,1,2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i]+",");
                
            }
            Console.WriteLine();
        }

        private static void RectMultidimensionalArray()
        {
            int[,] myMatrix;
            myMatrix=new int[6,6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myMatrix[i, j] = i*j;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myMatrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
