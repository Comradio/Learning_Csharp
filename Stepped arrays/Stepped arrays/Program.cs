using System;

namespace Stepped_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[5][];
            int[,] myArray2 = new int[10,5];

            // чтобы работать с элементами зубчатого массива, нужно преврарительно отдельно выделить память для этих вложенных массивов
            myArray[0] = new int[9];
            myArray[1] = new int[2];
            myArray[2] = new int[8];
            myArray[3] = new int[4];
            myArray[4] = new int[12];
            myArray[0][3] = 55;
            Random random = new Random();

            int[] arr = myArray[0];

            int myArrayRank = myArray.Rank;
            int myArrayRank2 = myArray2.Rank;

            int myArrayLength = myArray.Length;
            int myArrayLength2 = myArray2.Length;

            Console.WriteLine($"myArrayRank: {myArrayRank}");
            Console.WriteLine($"myArrayRank2: {myArrayRank2}");
            Console.WriteLine($"myArrayLength: {myArrayLength}");
            Console.WriteLine($"myArrayLength2: {myArrayLength2}");

            // заполнение ступенчатого массива случайными числами
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
