namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            TempConverter.FahrenheitToCelsius(51.0);
            TempConverter.CelsiusToFahrenheit(10.55555);
            Console.WriteLine("Enter in celsius degrees:");
            double whatIsTodaysTemp = double.Parse(Console.ReadLine());
            TempConverter.CelsiusToFahrenheit(whatIsTodaysTemp);
        }
    }
}
