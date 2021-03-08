using System;

namespace _2D_arrays_output
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
            {
                { 2, 45, 12, 51, 51 },
                { 6, 7, 8, 3, 1 },
                { 1, 5, 65, 78, 13 },
                { 6, 3, 151, 5, 65 }
            };

            Console.WriteLine($"Измерений массива: {myArray.Rank}");
            // количество строк
            Console.WriteLine($"Строк: {myArray.GetLength(0)}");
            // количество столбцов
            Console.WriteLine($"Столбцов: {myArray.GetLength(1)}");

            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
