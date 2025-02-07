using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class AnimalPoly
    {
        public virtual void SpeakPoly()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class DogPoly : AnimalPoly
    {
        public override void SpeakPoly()
        {
            Console.WriteLine("Dog barks.");
        }
    }
}
