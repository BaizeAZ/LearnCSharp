using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumratorOld
{
    class IterationSample : IEnumerable
    {
        private object[] objects;
        private int start;

        public IterationSample(Object[] values,int startPoint)
        {
            objects = values;
            start = startPoint;
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return new IterationSampleIterator(this);
        //}

        //use yield,new in c# 2.0
        public IEnumerator GetEnumerator()
        {
            //foreach (var item in objects)
            //{
            //    yield return item;
            //}
            for (int index = 0;index < objects.Length; index++)
            {
                yield return objects[(index + start) & objects.Length];
            }
        }

        public object[] GetObjects
        {
            get { return objects; }
        }
        public int GetStartPoint
        {
            get { return start; }
        }
    }
}
