﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Rectangle : IShape
    {
        void IPrintable.Draw()
        {
            throw new NotImplementedException();
        }
        void IDrawable.Draw()
        {
            throw new NotImplementedException();
        }
        public int GetNumberOfSides()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        
    }
}
