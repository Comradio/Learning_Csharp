using System;

namespace Null
{
    class MyClass
    {

    }

    struct MyStruct
    {

    }
    
    class Program
    {
        static void Foo()
        {
            int[] arr2 = new int[10];
        }
        static void Main(string[] args)
        {
            // False
            bool b;
            // 0
            int a;
            // 0
            double d;
            // null
            Random random;
            // т.к. не выделяли место в памяти, то здесь null
            int[] arr;
            // массив нулей
            int[] arr1 = new int[10];
            // связь между ссылкой в стэке и данными в куче удаляется
            arr1 = null;
            // null
            MyClass myClass;
            // дефолтное значение для структуры
            MyStruct myStruct;
            // после выполнения этого метода, ссылка на массив arr1 исчезнет
            // а данные удалятся сборщиком мусора
            Foo();
            
        }
    }
}
