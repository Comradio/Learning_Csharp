using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 2, 55 };
            int[] myArray1 = new int[5];
            int sum = 0;
            int least = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            // Заполнить массив с клавиатуры
            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.WriteLine("Введите {0} элемент массива: ", i);
                myArray1[i] = int.Parse(Console.ReadLine());
            }

            // Вывести массив в обратном порядке
            for (int i = myArray1.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine("{0} элемент массива: {1}", i, myArray1[i]);
            }

            // Найти сумму чётных элементов в массиве
            for (int i = 0; i < myArray1.Length; i=i+2)
            {
                sum += myArray1[i];
            }
            Console.WriteLine("Сумма чётных элементов: {0} ", sum);

            // Найти наименьшее число в массиве
            for (int i = 0; i < myArray1.Length; i++)
            {
                if (least > myArray1[i])
                {
                    least = myArray1[i];
                }
            }
            Console.WriteLine("Наименьшее число: {0} ", least);

        }
    }
}
