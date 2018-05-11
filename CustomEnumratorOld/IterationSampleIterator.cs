using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumratorOld
{
    class IterationSampleIterator : IEnumerator
    {
        private IterationSample parent;
        private int position;

        public IterationSampleIterator(IterationSample _parent)
        {
            parent = _parent;
            position = -1;
        }

        public object Current
        {
            get
            {
                if (position == -1||position==parent.GetObjects.Length)
                {
                    throw new InvalidOperationException("当前索引无效");
                }
                int index = position + parent.GetStartPoint;
                index = index % parent.GetObjects.Length;
                return parent.GetObjects[index];
            }
        }

        public bool MoveNext()
        {
            if (position < parent.GetObjects.Length)
            {
                position++;
            }
            return position < parent.GetObjects.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
