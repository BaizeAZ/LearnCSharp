using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Point:IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", this.X, this.Y);
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(Point other)
        {
            if (this.X>other.X&&this.Y>other.Y)
            {
                return 1;
            }
            else if (this.X<other.X&&this.Y<other.Y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point operator +(Point point, int value)
        {
            return new Point(point.X + value, point.Y + value);
        }
        public static Point operator +(int value, Point point)
        {
            return new Point(point.X + value, point.Y + value);
        }

        public static Point operator -(Point point, int value)
        {
            return new Point(point.X - value, point.Y - value);
        }
        public static Point operator -(int value, Point point)
        {
            return new Point(point.X - value, point.Y - value);
        }
        public static Point operator ++(Point point)
        {
            return new Point(point.X + 1, point.Y + 1);
        }
        public static Point operator --(Point point)
        {
            return new Point(point.X - 1, point.Y - 1);
        }

        public static bool operator == (Point p1,Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator != (Point p1,Point p2)
        {
            return !p1.Equals(p2);
        }

        public static bool operator < (Point p1,Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }
        public static bool operator > (Point p1,Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }
        public static bool operator <= (Point p1,Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }
        public static bool operator >= (Point p1,Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
    }
}
