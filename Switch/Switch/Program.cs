using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Введите цифру 1 или 2");
            a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("Введена цифра 1 или 2");
                    break;
                case 3:
                    Console.WriteLine("Введена цифра 3");
                    break;
                default:
                    Console.WriteLine("Введено число не 1, не 2 и даже не 3");
                    break;
            }
        }
    }
}
