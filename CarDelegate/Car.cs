using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead; 

        public Car() { MaxSpeed = 100; }
        public Car(string name,int maxSp,int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        //定义委托类型
        public delegate void CarEnginHandler(string msgForCaller);

        //定义每个委托类型的成员变量
        private CarEnginHandler listOfHandlers;//这里如果定义为公共的委托成员变量的话，下面的注册函数就不需要了，但是这样做有安全风险
        
        //向调用者添加注册函数
        //现在支持多路广播，现在正在使用+=操作符
        public void RegisterWithCarEngine(CarEnginHandler methodTocall)
        {            
            listOfHandlers += methodTocall;
            //Delegate.Combine(listOfHandlers, methodTocall);
        }

        //从委托的调用列表中移除成员
        public void UnRegisterWithCarEngine(CarEnginHandler methodcall)
        {
            listOfHandlers -= methodcall;
        }
        
        //实现此方法在某些情况下调用委托的调用列表
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                listOfHandlers?.Invoke("Sorry,this car is dead...");

            }
            else
            {
                CurrentSpeed += delta;
                //提醒快不能用了
                if (10==MaxSpeed-CurrentSpeed&& listOfHandlers!=null)
                {
                    listOfHandlers(" Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed>=MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed={0}", CurrentSpeed);
                }

            }
        }
    }
}
