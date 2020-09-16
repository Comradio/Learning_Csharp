using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, count = 0;

            limit = int.Parse(Console.ReadLine());

            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}
