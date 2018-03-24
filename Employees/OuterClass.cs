using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //内部类默认私有
    class OuterClass
    {
        public int intNumber;
        public class PublicInnerClass
        {
            private int privateIntNum;
            public int publicIntNum;
        }

        private class PrivateInnerClass
        {
            private string privateStr;
            public string publicStr;
        }
        
    }
}
