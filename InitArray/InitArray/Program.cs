using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Способы инициализации массива
            // 1
            int[] myArray1;
            myArray1 = new int[4] { 1, 3, 4, 6 };
            // 2
            int[] myArray2 = new int[4] { 4, 6, 2, 3 };
            // 3
            int[] myArray3 = new[] { 5, 3, 6, 3, 6, 2 };
            // 4
            int[] myArray4 = { 4, 7, 9, 2, 1 };
            // 5
            // Инициализация массива заданным значением всех элементов
            int[] myArray5 = Enumerable.Repeat(5, 10).ToArray();

            // Заполнение массива определёнными эелемtнтами, начиная с какого-то значения и увеличение значения на 1
            // в каждом следующем эелемнте
            int[] myArray6 = Enumerable.Range(4, 5).ToArray();

        }
    }
}