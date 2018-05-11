using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//~~~~~~~~~~~如果返回类型和参数都相同，在同一个类中定义显式和隐式转换函数是非法的！！！！！
//~~~~~~~~~~但当一个类型定义了隐式转换后，调用者在使用显式强制类型转换语法是合法的！！！！
namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();

            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Console.Read();
        }
    }

    struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int w,int h)
        {
            Width = w;
            Height = h;
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return string.Format("Width:{0},Height:{1}", Width, Height);
        }

        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle();
            r.Height = s.Length;
            r.Width = s.Length * 2;
            return r;
        }
    }

    struct Square
    {
        public int Length { get; set; }
        public Square(int length)
        {
            Length = length;
        }

        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return string.Format("Length:{0}", Length);
        }

        //自定义显式转换
        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square();
            s.Length = r.Height;
            return s;
        }
        public static explicit operator Square(int length)
        {
            Square s = new Square(length);
            return s;                        
        }
        public static explicit operator int(Square s)
        {             
            return s.Length;
        }
        //自定义隐式转换        

    }
}
