using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hex=new Hexagon();
            Console.WriteLine("Points:{0}",hex.Points);
            //判断类型是否支持此接口的方法1
            //通过显示强制转换，如果转换成功则支持，转换失败反之，失败会发生异常需要捕获。
            Circle c=new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy) c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
                
            }
            //判断类型是否支持此接口的方法2
            //通过as和is关键字，as返回值为null的空引用或者指向该对象（在此为对象接口）的引用；
            //is返回true或false;

            //as:
            Hexagon hex2=new Hexagon("Peter");
            IPointy itfPt2=hex2 as IPointy;
            if (itfPt2!=null)
            {
                Console.WriteLine("Points:{0}",hex2.Points);
            }
            else
            {
                Console.WriteLine("OOPS! Not pointy...");
            }
            //is
            Shape[] myShapes = {new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo")};
            for (int i = 0; i < myShapes.Length; i++)
            {
                //回调Shape基类定义一个抽象的Draw()成员，由此所有Shape都知道如何绘制自己
                myShapes[i].Draw();
                //哪些是有棱角的
                if (myShapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points:{0}",((IPointy)myShapes[i]).Points);
                }
                else
                {
                    Console.WriteLine("{0}\'s not pointy!",myShapes[i].PetName);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");
            
            Shape[] myShapes2 = {new Hexagon(), new Circle(), new Triangle(), new Circle("JoJo")};
            for (int i = 0; i < myShapes2.Length; i++)
            {
                //判断支持绘制为3D嘛
                if (myShapes2[i] is IDraw3D)
                {
                    DrawIn3D((IDraw3D)myShapes2[i]);
                }
            }
            //获取第一个pointy项

            IPointy firstPointyItem = FindFirstPointyShape(myShapes2);
            if (firstPointyItem!=null)
            {
                Console.WriteLine("The item has {0} points", firstPointyItem.Points);
            }

            //接口类型数组
            //**********下面这个示例说明了：如果有一个给定接口的数组，那么这个数组可以包含实现了该接口的任何类或者结构**********
            IPointy[] myPointyObjects = {new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork()};
            foreach (IPointy i in myPointyObjects)
            {
                Console.WriteLine("Objects has {0} points.",i.Points);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        //接口作为参数
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("->Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }
        //接口作为返回值
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            //返回实现IPointy的数组中的第一个对象
            foreach (Shape s in shapes)
            {
                if (s is  IPointy)
                {
                    return s as IPointy;
                }
            }
            return null;
        }
    }
}
