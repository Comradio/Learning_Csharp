using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5];

            myArray[0] = 10;
            myArray[1] = 3;

            int a = myArray[0];

            Console.WriteLine(a);
            Console.WriteLine(myArray.Length);

            Console.ReadLine();
        }
    }
}
