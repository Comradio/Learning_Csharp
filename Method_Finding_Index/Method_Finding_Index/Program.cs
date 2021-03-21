using System;

namespace Method_Finding_Index
{
    class Program
    {
        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "\t");
            }
            Console.WriteLine();
        }
        static int IndexOf(int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);

            PrintArray(myArray);

            int result = IndexOf(myArray, 2);
            Console.WriteLine($"Индекс искомого элемента: {result}");
        }
    }
}
