using System;
using System.Linq;

/*  ?.  */

namespace Conditional_null
{
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;

            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементов массива: " + (myArray?.Sum() ?? 0));
        }
    }
}
