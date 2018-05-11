using System;

namespace _000_练习
{
    struct Rectangle
    {
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info,int top,int left,int bottom,int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectLeft = left;
            rectBottom = bottom;
            rectRight = right;

        }

        public void display()
        {
            Console.WriteLine("string={0},top={1},left={2},bottom={3},right={4}",
                rectInfo.stringInfo, rectTop, rectLeft, rectBottom, rectRight);

        }
    }
}
