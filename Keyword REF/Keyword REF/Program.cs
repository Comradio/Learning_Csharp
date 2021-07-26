using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_REF
{
    
    class Program
    {
        static void Foo(ref int a, ref int b, ref int c)
        {
            a = -5;
            b = -5;
            c = -5;
        }

        struct MyStruct
        {
            public int a;
            public double b;
            public float c;
        }

        static void Foo1(ref MyStruct myStruct)
        {
            myStruct.a = -5;
        }

        class MyClass
        {
            public int a;
            public double b;
            public float c;
        }

        static void Foo2(MyClass myClass)
        {
            myClass.a = -5;
        }

        static void Bar(ref int[] arr, ref int[] arr1)
        {
            arr = null;
            arr1 = new int[] { 18, 4, 5, 6, 7};
        }

        static ref int Bar1(int[] numbers)
        {
            return ref numbers[0];
        }
        static void Main(string[] args)
        {
            /* Можно "возвращать" несколько переменных в качестве результата, но делать так не нужно */
            int a = 2;
            int b = -1;
            int c = 8;
            Foo(ref a, ref b, ref c);
            Console.WriteLine(a);

            /* Изменение значения поля через ссылку */
            MyStruct myStruct = new MyStruct();
            Foo1(ref myStruct);

            /* Изменение значения поля через ссылку */
            MyClass myClass = new MyClass();
            Foo2(myClass);
            Console.WriteLine(myClass.a);

            /* Изменение ссылки на массив */
            int[] myArray = { 1, 4, 6 };
            int[] myArray1 = { 4, 4};
            Bar(ref myArray, ref myArray1);

            /* Ссылочные локальные переменные */
            int[] myArrayg = { 2, 5, 0};
            ref int g = ref myArrayg[0];
            g = -5;

            /* Возвращаемые ссылочные значения */
            int[] myArrayt = { 4, 1, 4 };
            ref int t = ref Bar1(myArrayt);
            t = -5;
        }
    }
}
