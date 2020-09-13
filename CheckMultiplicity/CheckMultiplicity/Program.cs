using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, temp;
            bool result;

            Console.WriteLine("Введите число для проверки: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Кратно ли числу...? ");
            temp = int.Parse(Console.ReadLine());

            result = a % temp == 0;

            if (result)
            {
                Console.WriteLine("Число " + a + " кратно числу " + temp);
            }
            else
            {
                Console.WriteLine("Число " + a + " не кратно числу " + temp);
            }
        }
    }
}
