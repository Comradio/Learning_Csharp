using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperation
{
    class Program
    {
        
        public static bool GetTemperature()
        {
            return true;
        }

        public static bool GetCoolingStatus()
        {
            return true;
        }

        static void Main(string[] args)
        {
            if (GetTemperature() && GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!");
            }

            // Более параноидальная версия
            if (GetTemperature() && GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!");
            }

        }
    }
}
