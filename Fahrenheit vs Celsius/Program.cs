using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitvsCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;

            Console.WriteLine("Hoeveel graden het buiten is?");
            a = Convert.ToInt32(Console.ReadLine());

            //f = (9 / 5) * y + 32;

            b = 1.80 * a + 32;

            Console.WriteLine(b + " aantalgraden Fahrenheit gelijk is aan " + a + " aantal graden Celsius");
            Console.ReadLine();















        }
    }
}
