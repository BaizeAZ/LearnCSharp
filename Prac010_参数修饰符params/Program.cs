using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac010_参数修饰符params
{
    class Program
    {
        static void Main(string[] args)
        {
            //传递一个以逗号分隔的double型数的列表
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            //或传递一个double型的数组
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            //0的平均值是0
            Console.WriteLine("Average of data is: {0}", CalculateAverage());

            Console.ReadLine();
        }
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);
            double sum = 0;
            if (values.Length == 0)            
                return sum;

            for(int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }
    }
}
