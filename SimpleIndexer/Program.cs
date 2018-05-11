using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class Program
    {       

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexer *****");

            PersonConllection myPeople = new PersonConllection();
            myPeople.AddPerson(new Person("he", "jj", 23));
            myPeople.AddPerson(new Person("bbb", "ccc", 12));
            myPeople.AddPerson(new Person("aaa", "ddd", 33));
            Console.WriteLine(myPeople[0].MyFirstName);
            Console.WriteLine(myPeople[1].MyFirstName);
            Console.WriteLine(myPeople[2].MyFirstName);
            Console.ReadKey();
        }        

    }
}
