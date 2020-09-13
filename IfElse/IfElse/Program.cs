using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInfected;
            float temp;

            Console.WriteLine("Введите значение температуры тела персонажа: ");
            temp = float.Parse(Console.ReadLine());

            if (temp > 37.2)
            {
                isInfected = true;
            }
            else
            {
                isInfected = false;
            }

            if (isInfected)
            {
                Console.WriteLine("Персонаж болен!");
            }
            else 
            {
                Console.WriteLine("Персонаж здоров!");
            }
        }
    }
}
