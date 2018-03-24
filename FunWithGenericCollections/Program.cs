using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseGenericList();
            //UseGenericStack();
            UseGenericQueue();
            UseSortedSet();
            Console.ReadKey();
        }
        static void UseGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person {F_Name="Homer",L_Name="Simpson", Age=47},
                new Person {F_Name="Marge",L_Name="Simpson", Age=45},
                new Person {F_Name="Lisa",L_Name="Simpson",Age=9 },
                new Person {F_Name="Bart",L_Name="Simpson",Age=8 }
            };
            Console.WriteLine("Items in list: {0}", people.Count);

            foreach (var p in people)            
                Console.WriteLine(p);

            //插入一个新Person
            Console.WriteLine("\n->Inserting new person");
            people.Insert(2, new Person() { F_Name = "Maggie", L_Name = "Simpson", Age = 2 });
            Console.WriteLine("Items in list:{0}", people.Count);
            //将数据复制到新的数组中
            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("FirstName: {0}", arrayOfPeople[i].F_Name);
            }
        }
        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person()
                { F_Name = "Homer", L_Name = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person()
                { F_Name = "Marge", L_Name = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person()
                { F_Name = "Lisa", L_Name = "Simpson", Age = 9 });

            //观察栈的项，取出，再次观察
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            Console.WriteLine("\nFirst person is; {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            Console.WriteLine("\nFirst person is; {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("\nnFirst person is; {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
                
            }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!",p.F_Name);
        }
        static void UseGenericQueue()
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person()
                { F_Name="Homer",L_Name="Simpson",Age=47});
            peopleQ.Enqueue(new Person()
                { F_Name="Marge",L_Name="Simpson",Age=45});
            peopleQ.Enqueue(new Person()
                { F_Name="Lisa",L_Name="Simpson",Age=9});

            Console.WriteLine("{0} is first in line!", peopleQ.Peek().F_Name);

            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error! {0}", ex.Message);
            }
        }

        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople=new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person() {F_Name = "Homer",L_Name = "Simpson",Age = 47},
                new Person() {F_Name = "Marge",L_Name = "Simpson",Age = 45},
                new Person() {F_Name = "Lisa",L_Name = "Simpson",Age = 9},
                new Person() {F_Name = "Bart",L_Name = "Simpson",Age = 8}
            };

            foreach (var p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            setOfPeople.Add(new Person() {F_Name = "Saku", L_Name = "Jones", Age = 1});
            setOfPeople.Add(new Person() {F_Name = "Mikko", L_Name = "Jones", Age = 32});

            foreach (var p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }
    }
}
