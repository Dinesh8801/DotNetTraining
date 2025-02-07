using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Pyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How high do you want your pyramid");
            int num = Convert.ToInt32(Console.ReadLine());
            DrawPyramid(num);
        }
        public static void DrawPyramid(int num)
        {
            for (int y = 1; y <= num; y++)
            {
                for (int h = 1; h <= (num - y); h++)
                {
                    Console.Write("-");
                }
                for (int p = 1; p <= ((y*2) - 1); p++)
                {
                    Console.Write("*");
                }
                for(int h = 1; h <= ((num - y) - 1); h++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }
        }
    }
}
