﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a Circle.");
    }

    public class Rectangle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a Rectangle.");
    }
}
