using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac012_属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("aadfadfadfadffadfadfadf", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();
            Employee.Name = "Marvin";
            emp.Age = 21;
            emp.DisplayStats();
            emp.Age++;//用.Net属性的方法简化后的代码，原：emp.SetAge(emp.GetAge()+1);
            emp.DisplayStats();
            Console.ReadLine();
        }

    }
    class Employee
    {
        private static string empName;
        private static int empID;
        private float currPay;
        private int empAge;
        //public int Type { get; set; }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public static string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!!");
                else
                    empName = value;
            }
        }
        public static int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, id, pay, 0) { }
        public Employee(string name, int id, float pay, int age)
        {
            //empName = name;
            //empID = id;
            //currPay = pay;
            //empAge = age;
            ////为了把所有的错误检查隔离到中心位置，可以一直在类中使用属性，不管你何时需要获取或设置属性的值
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
        }

        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("ID:{0}", ID);
            Console.WriteLine("Pay:{0}", Pay);
            Console.WriteLine("Age:{0}", Age);
        }
    }
}
