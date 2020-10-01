using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int rows, cols;
            ch = char.Parse(Console.ReadLine());
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
