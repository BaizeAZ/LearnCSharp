using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class PersonConllection:IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }

        private ArrayList arPeople = new ArrayList();
        //类的自定义索引器
        public Person this[int index]
        {
            get { return (Person)arPeople[index]; }
            set { arPeople.Insert(index, value); }
        }
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }
        public void ClearPeople()
        {
            arPeople.Clear();
        }
        public int Count
        {
            get { return arPeople.Count; }
        }

    }
}
