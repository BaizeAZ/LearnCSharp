using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumrator
{
    class Car
    {
        private const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        public Car() { }
        public Car(string name,int speed)
        {
            CurrentSpeed = speed;
            PetName=name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...",PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed>=MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;
                    
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed={0}",CurrentSpeed);
                }
                
            }
        }

    }
}
