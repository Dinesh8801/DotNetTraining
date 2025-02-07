using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
	public interface IAnimal
    {
        void Speak(); // Interface method (no implementation)
    }

    public class DogAbs : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
}
