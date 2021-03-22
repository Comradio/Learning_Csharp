using System;
using System.Net;

namespace Method_overloading
{
    /// <summary>
    /// Тест))0)0)))
    /// </summary>
    class Program
    {
        /// <summary>
        /// Возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Возвращает сумму трёх целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Возвращает сумму двух дробных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int result = Sum(2, 3);
            Console.WriteLine(result);

            result = Sum(2, 3, 4);
            Console.WriteLine(result);

            double resultD = Sum(5.5, 6.3);
            Console.WriteLine(resultD);
        }
    }
}
