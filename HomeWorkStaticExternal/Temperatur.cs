using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStaticExternal
{
    internal static class Temperatur
    {
        public static void Fahraneit(double x)
        {
            double f = x * 1.8 + 32;
            Console.WriteLine(f);
        }
        // a = (x*1.8)+32
        // a - 32 = x * 1.8
        // (a -32) / 1,8 = x
        public static void Celsius(double x)
        {
            double f = (x - 32) / 1.8 ;
            double num = Math.Round(f);

            Console.WriteLine(num);
        }
    }
}
