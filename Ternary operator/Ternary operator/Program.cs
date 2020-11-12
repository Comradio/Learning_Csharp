using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_operator
{
    // [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            accessAllowed = enteredPassword == storedPassword ? true : false;

            Console.WriteLine(accessAllowed);
        }
    }
}
