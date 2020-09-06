using System;
using System.Globalization;

namespace Global
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1,9";
            string str1 = "1.9";
            double a, b;

            a = Convert.ToDouble(str);
            Console.WriteLine(a);

            /*
             *  Без этого при выводе str1 появится ошибка
             */
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            b = Convert.ToDouble(str1, numberFormatInfo);
            Console.WriteLine(b);
        }
    }
}
