using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertation
{
    /*
     * Type conversion and casting is not the same
     * -------------------------------------------
     * class Convert
     */

    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Сумма чисел = " + result);
            Console.ReadKey();
        }
    }
}
