using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {

        public Shape(string name="NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }

        public abstract void Draw();//抽象成员方法，强制子类来定义如何被呈现，抽象方法只能定义在抽象类中
    }
}
