using System;

namespace _2demention_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // синтаксис создания двумерного массива
            int[,] myArray = new int[3,5];
            int[,] myArray1 = new int[3, 5]
            {
                { 2, 45, 12, 51, 51 },
                { 6, 7, 8, 3, 1 },
                { 1, 5, 65, 78, 13 }
            };
            int[,] myArray2 = new int[,]
            {
                { 2, 45, 12, 51, 51 },
                { 6, 7, 8, 3, 1 },
                { 1, 5, 65, 78, 13 }
            };
            int[,] myArray3 = 
            {
                { 2, 45, 12, 51, 51 },
                { 6, 7, 8, 3, 1 },
                { 1, 5, 65, 78, 13 }
            };

            myArray[0,2] = 99;

            Console.WriteLine(myArray[0,2]);
        }
    }
}
