using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace StaticExercise
{
    internal static class TempConverter
        
    {
        public static double FahrenheitToCelsius(double fTemp) 
        {
            double celcius = (fTemp - 32) * 5 / 9;
            Console.WriteLine(celcius);
            return celcius;
        }

        public static double CelsiusToFahrenheit(double cTemp) 
        {
            double fahenheit = (cTemp * 9) / 5 + 32;
            Console.WriteLine(fahenheit);
            return fahenheit;
        }

    }
}
