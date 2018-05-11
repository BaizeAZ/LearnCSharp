using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            BitMapImage btmi = new BitMapImage();
            //从对象级别调用
            btmi.Draw();
            btmi.DrawInBoundingBox(10,10,20,120);
            btmi.DrawUpSideDown();

            //显示获取IAdvancedDraw
            IAdvancedDraw iAdvDraw = btmi as IAdvancedDraw;
            if (iAdvDraw!=null)
            {
                iAdvDraw.DrawUpSideDown();
            }
            Console.ReadLine();
        }
    }
}
