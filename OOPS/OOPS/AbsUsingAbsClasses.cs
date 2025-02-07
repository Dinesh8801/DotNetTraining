using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public abstract class AnimalAbs
    {
        public abstract void SpeakAbs(); // Abstract method (no implementation)

        public void EatAbs() // Concrete method (has implementation)
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    public class CatAbs : AnimalAbs
    {
        public override void SpeakAbs()
        {
            Console.WriteLine("Cat meows.");
        }
    }
}
