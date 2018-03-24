using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape[] myShapes= {new Hexagon(),new Circle(),new Hexagon("Mick"),
                new Circle("Beth"),new Hexagon("Linda")};
            foreach (var VARIABLE in myShapes)
            {
                VARIABLE.Draw();
            }

            ThreeDCircle o=new ThreeDCircle();
            o.Draw();
            //调用了父类的Draw()方法
            ((Circle)o).Draw();

            Console.ReadKey();
            
        }
    }
}
