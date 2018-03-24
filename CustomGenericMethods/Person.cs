using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Person
    {
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string _fname, string _lname, int _age)
        {
            F_Name = _fname;
            L_Name = _lname;
            Age = _age;
        }
        public override string ToString()
        {
            return string.Format("Name: {0} {1} Age: {2}", F_Name,L_Name,Age);
        }
    }
}
