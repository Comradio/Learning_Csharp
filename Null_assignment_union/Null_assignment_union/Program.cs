using System;

namespace Null_assignment_union
{
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;

            return myArray;
        }
        static void Main(string[] args)
        {
            string str1 = null;
            string str2 = "test";
            string str3 = "";

            // если переменная null, то добавляет к ней дефолтное значение
            // если переменная не null, то она не меняется
            str1 ??= "default string";
            str2 ??= "default string";
            str3 ??= "default string";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            // GetArray() возвращает null
            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine("Количество элементов в массиве: " + myArray.Length);
        }
    }
}
