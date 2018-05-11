using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {

        protected int EmpID;
        protected int EmpAge;
        protected float CurrentPay;
        protected string name;
        protected string empSSN;

        //public int EmpID { get; set; }
        //public int EmpAge { get; set; }
        //public float CurrentPay { get; set; }
        //private string name;
        //private string empSSN;
        protected string EmpName
        {
            get { return name; }
            set
            {
                if (value.Length>15)
                {
                    Console.WriteLine("Error!");
                }
                else
                {
                    name = value;
                }                
            }
        }

        protected string SocialSecurityNumber
        {
            get { return empSSN;}
        }
        public Employee() { }
        public Employee(string _name,int _ID,float _Pay) : this(_name, 0, _ID, _Pay," ") { }

        public Employee(string _name, int _Age, int _ID, float _Pay,string _SSN)
        {
            EmpName = _name;
            EmpID = _ID;
            CurrentPay = _Pay;
            EmpAge = _Age;
            empSSN = _SSN;
        }

        public virtual void GiveBonus(float amount)
        {
            CurrentPay += amount;
        }
        public virtual void DisPlay()
        {
            Console.WriteLine("Name:{0}",EmpName);
            Console.WriteLine("ID:{0}",EmpID);
            Console.WriteLine("Age:{0}",EmpAge);
            Console.WriteLine("CurrentPay:{0}",CurrentPay);
            Console.WriteLine("SocialSecurityNumber:{0}",SocialSecurityNumber);
        }

    }
}
