using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumrator
{
    public interface IEnumerable
    {
         IEnumerator GetEnumerator();
    }
}
