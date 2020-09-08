using System;
using System.Globalization;

namespace ConversationWithParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "5";
            int a = int.Parse(str);
            Console.WriteLine("a = " + a);

            string str1 = "5,9";
            double b = double.Parse(str1);
            Console.WriteLine("b = " + b);

            string str2 = "5.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double c = double.Parse(str2, numberFormatInfo);
            Console.WriteLine("c = " + c);

            string str3 = "5wet";
            try
            {
                int d = int.Parse(str3);
                Console.WriteLine("Успешная конвертация, d = " + d);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертации d");
            }

            string str4 = "5";
            int e;
            bool result = int.TryParse(str4, out e);
            if (result)
            {
                Console.WriteLine("Операция успешна, e = " + e);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать e!");
            }

            string str5 = "6uih ouhbipf oibnfiod";
            int f;
            bool result1 = int.TryParse(str5, out f);
            if (result1)
            {
                Console.WriteLine("Операция успешна, f = " + f);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать f!");
            }

        }
    }
}
