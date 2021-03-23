using System;

namespace Area_of_visibility
{
    class Program
    {
        // эта переменная не является статической
        int c = 5;
        static int d = 10;
        static int f = 12;
        static void Foo()
        {
            // эта переменная не видна за пределами метода
            int b = 9;
            int d = 11;

            // выведена будет та из переменных, которая была создана в этой же области видимости
            Console.WriteLine(d);
            // далее по иерархии областей видимости идёт область класса, а не метода Main
            Console.WriteLine(f);
        }
        static void Main(string[] args)
        {
            int a = 2;
            int f = 13;

            for (int i = 0; i < 10; i++)
            {
                //переменная i не видна за пределами цикла
                i++;
                a++;
            }
            // следовательно, эта переменная недоступна в статических методах
            //c++;
            // а эта - доступна
            Foo();
            d++;
        }
    }
}
