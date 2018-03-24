using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    interface IPointy
    {
        //不能使用访问修饰符，隐式公共的。
        //byte GetNumberOfPoints();
        byte Points { get; }
    }
}
