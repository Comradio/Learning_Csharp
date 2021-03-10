using System;
using System.Text;

namespace _3D_and_more_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,,] myArray = new int[4, 3, 5];
            int[,,] myArray = 
                {
                    {
                        { 5, 2, 6 },
                        { 6, 32, 7 }
                    },
                    {
                        { 7, 23, 78 },
                        { 2, 34, 856 },
                    },
                    {
                        { 6, 3, 1 },
                        { 73, 34, 12 }
                    }
                };
            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(1000);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine($"Page №{i}");
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            // зубчаный трёмерный массив
            int[][][] myArray1 = new int[random.Next(3, 6)][][];

            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i] = new int[random.Next(2, 6)][];
                for (int j = 0; j < myArray1[i].Length; j++)
                {
                    myArray1[i][j] = new int[random.Next(2, 6)];
                    for (int k = 0; k < myArray1[i][j].Length; k++)
                    {
                        myArray1[i][j][k] = random.Next(1000);
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.WriteLine($"Page №{i}");
                for (int j = 0; j < myArray1[i].Length; j++)
                {
                    for (int k = 0; k < myArray1[i][j].Length; k++)
                    {
                        Console.Write(myArray1[i][j][k] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
