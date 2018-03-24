using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class Person
    {
        public string MyFirstName { get; set; }
        public int MyAge { get; set; }
        public string MyLastName { get; set; }

        public Person() { }

        public Person(string firstName,string lastName,int age)
        {
            MyFirstName = firstName;
            MyLastName = lastName;
            MyAge = age;
        }
        public override string ToString()
        {
            return string.Format("Name:{0} {1} Age:{2}", MyFirstName, MyLastName, MyAge);

        }
    }
}
