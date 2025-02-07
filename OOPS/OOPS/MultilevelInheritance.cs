using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Grandparent
    {
        public void GrandparentMethod() => Console.WriteLine("Grandparent method.");
    }

    public class Parent : Grandparent
    {
        public void ParentMethod() => Console.WriteLine("Parent method.");
    }

    public class Child : Parent
    {
        public void ChildMethod() => Console.WriteLine("Child method.");
    }
}
