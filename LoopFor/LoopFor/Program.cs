using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            for (;;)
            {
                Console.WriteLine("for is working");
                System.Threading.Thread.Sleep(300);
                break;
            }

            /*
            int i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("for_1: " + i);
            }

            for (; i < 5; i++)
            {
                Console.WriteLine("for_2: " + i);
            }
            */

            for (int i = 0; i < 5;)
            {
                i++;
                Console.WriteLine("for_2: " + i);
            }
            

            for (int i = 0, j = 5; i < 10 && j < 11; i++, j++)
            {
                Console.WriteLine("i: " + i + "  " + "j: " + j);
            }

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("Декремент: " + i);
            }

            for (int i = 0, j = 5; i < 10 && j > 0; i++, j--)
            {
                Console.WriteLine("i: " + i + "  " + "j: " + j);
            }
        }
    }
}
