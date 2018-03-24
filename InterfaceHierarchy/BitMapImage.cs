using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class BitMapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Draw in a box...");
        }

        public void DrawUpSideDown()
        {
            Console.WriteLine("Drawing upsidedown...");
        }
    }
}
