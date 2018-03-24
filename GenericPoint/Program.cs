using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p = new Point<int>(10, 20);
            Console.WriteLine("{0}",p.ToString());
            p.ResetPoint();
            Console.WriteLine("{0}", p.ToString());

            Point<double> p1 = new Point<double>(1.2, 3.4);
            Console.WriteLine("{0}", p1.ToString());
            p1.ResetPoint();
            Console.WriteLine("{0}", p1.ToString());

            
            Console.ReadLine();
        }

        public struct Point<T> where T : struct
        {
            private T xPos;
            private T yPos;

            
            public Point(T xVal,T yVal)
            {
                xPos = xVal;
                yPos = yVal;
            }

            public T X
            {
                get { return xPos; }
                set { xPos = value; }
            }
            public T Y
            {
                get { return yPos; }
                set { yPos = value; }
            }
            public override string ToString()
            {
                return string.Format("[{0},{1}]", X, Y);
            }
            //重置字段为类型参数的默认值
            public void ResetPoint()
            {
                xPos = default(T);
                yPos = default(T);
            }
        }
    }
}
