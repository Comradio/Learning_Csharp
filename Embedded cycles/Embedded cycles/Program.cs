using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedded_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Цикл 1, итерация № " + i);

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\tцикл 2, итерация № " + j);
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("\t\tцикл 3, итерация № " + k);
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
