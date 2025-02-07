using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public interface IWalk
    {
        void Walk();
    }

    public interface IRun
    {
        void Run();
    }

    public class Human : IWalk, IRun
    {
        public void Walk() => Console.WriteLine("Human is walking.");
        public void Run() => Console.WriteLine("Human is running.");
    }
}
