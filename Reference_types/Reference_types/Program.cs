﻿using System;
using System.Buffers;

namespace Reference_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // структура => размещается в стеке
            int a = 5;

            // класс => размещается в куче
            Random random = new Random();

            // массив - наследник класса array, следовательно, все массивы
            // являются ссылочными типами и размещаются в управляемой куче
            int[] myArray = new int[10];

            // strack и enum перестают существовать, когда  покидают контекст,
            // в котором они были определены

            {
                int b = 3;
            }

            // классы перестают существовать, когда подвергаются сборке мусора,
            // т.е., при выходе из контекста удаляются только ссылки на классы,
            // т.к. ссылка на класс хранится в стеке, но сам класс продолжает 
            // существовать в куче

            // "=" в случае struct и enum копирует значение переменной
            int y = 10;
            int u;

            u = y; // => в стеке появится два значения 10 и они больше никак не связаны

            // "=" в случае ссылочных типов копирует только ссылку, которая находится в стеке
            // само значение остаётся в единственном экземпляре, следовательно,
            // изменения значений через один из ссылочный тип приведёт к тем же изменениям
            // и в другом ссылочном типе (ведь это один и тот же объект)

            int[] arrayA = { 3, 5, 1 };
            int[] arrayB;

            arrayB = arrayA; // => в стеке появится две ссылки на объект, который находится в
                             // куче и был создан в строке 42

            a = 1;
            Foo(a);

            Console.WriteLine(arrayB[0] + " " + arrayA[0]);
            Bar(arrayB);

            Console.WriteLine(a);
            Console.WriteLine(arrayB[0] + " " + arrayA[0]);
        }
        static void Foo(int value)
        {
            // здесь изменение значения этой переменной не приведёт к изменению исходной переменной a
            value = 5;
        }
        static void Bar(int[] arr)
        {
            // отсюда изменения отобразятся и в массиве arrayA и в массиве arrayB
            arr[0] = 5;
        }
    }
}
