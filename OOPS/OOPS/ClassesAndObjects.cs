﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {Make} {Model} is driving.");
        }
    }
}
