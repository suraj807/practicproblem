﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicproblem.ClassandObject
{
    internal class car
    {
        public string carName, carColor;

        public car(string carName, string carColor)
        {
            this.carName = carName;
            this.carColor = carColor;
        }
        public void CarDetails()
        {
            Console.WriteLine($"Name of car is : {carName}\nColor of car is : {carColor}\n");
        }
    }
}
