using System;

namespace _2D_arrays_output
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 3];
            Random random = new Random();

            /*for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next();
                }
            }*/

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"I: {i} J: {j}");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

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
