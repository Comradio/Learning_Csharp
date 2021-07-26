using System;

namespace join_assignment_with_null
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
            string str = null;
            str ??= string.Empty;
            Console.WriteLine("Количество символов в строке: " + str.Length);
            
            int[] myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine("Количество элементов в массиве: " + myArray.Length);
        }
    }
}
