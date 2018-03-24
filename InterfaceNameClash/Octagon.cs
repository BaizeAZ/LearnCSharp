using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon:IDrawToForm,IDrawToMemory,IDrawToPrinter
    {
        //要实现具有相同成员的接口，可以用显示接口实现语法来解决这种命名冲突
        //显示接口实现总是隐式私有的，所以不能带有访问修饰符
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer");
        }
    }
}
