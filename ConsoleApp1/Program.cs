using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 10);
            oddOrEven(r);
        }

        static int oddOrEven(int num)
        {
            int rem = num % 2;
            if (rem == 0)
            {
                Console.WriteLine("Even");
                return num;
            }

            else
            {
                Console.WriteLine("Odd");
                return num;
            }
        }
    }
}
