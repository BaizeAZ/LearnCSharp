using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac013_初始化内部类型
{
    public enum PointColor
    {
        LightBlue, Gold, BloodRed
    }
    class Point
    {
        public int Y { get; set; }
        public int X { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            Y = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }
        public Point() : this(PointColor.BloodRed) { }

        public void DisplayStats()
        {
            Console.WriteLine("[{0},{1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }
    }
    class Rectangle
    {
        //因为自动属性会把所有的内部类变量设置为null,所以不能用自动属性
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0},{1},{2} BottomRight: {0},{1},{2}]", TopLeft.X, TopLeft.Y, TopLeft.Color,
                BottomRight.X, BottomRight.Y, BottomRight.Color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //初始化内部类型
            Rectangle myRect = new Rectangle()
            {
                TopLeft = new Point() { X = 10, Y = 10 },
                BottomRight = new Point() { X = 200, Y = 200 }
            };
        }
    }
}
