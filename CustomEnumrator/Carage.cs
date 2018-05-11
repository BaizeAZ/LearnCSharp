﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumrator
{
    class Carage:IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Carage()
        {
            carArray[0] = new Car("Rusty",30);
            carArray[1] = new Car("Clunker",55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);  
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}