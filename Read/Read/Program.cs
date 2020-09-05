using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Введите своё имя:");
            name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");
        }
    }
}
