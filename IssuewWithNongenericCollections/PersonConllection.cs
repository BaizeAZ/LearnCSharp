using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuewWithNongenericCollections
{
    class PersonConllection:IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }

        private ArrayList arPeople = new ArrayList();

        public Person GetPerson(int pos)
        {
            return (Person)arPeople[pos];
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
