using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lap1.obj
{
    public class Exercise10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }
    }
}