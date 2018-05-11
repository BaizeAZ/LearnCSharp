using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    public class Car
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

        //创建自定义的事件参数,开始修改委托=>利用泛型EventHandler<T>类型来进一步简化，不需要自定义委托类型
        //public delegate void CarEngineHandler(object sender,CarEventArgs e);
        // T 就是自定义的EventArgs类型
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;       

        //实现此方法在某些情况下调用委托的调用列表
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry,this car is dead..."));
                //Exploded?.Invoke("Sorry,this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                //提醒快不能用了
                if (10==MaxSpeed-CurrentSpeed&& AboutToBlow!=null)
                {
                    AboutToBlow(this,new CarEventArgs(" Careful buddy! Gonna blow!"));
                }
                if (CurrentSpeed>=MaxSpeed)
                {                 
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
