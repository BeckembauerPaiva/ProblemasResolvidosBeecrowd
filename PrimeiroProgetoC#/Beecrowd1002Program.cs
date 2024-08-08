using System;
using System.Globalization;

namespace PrimeiroProgeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, n, raio;
            n = 3.14159;

            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            raio = Math.Pow(raio,2);
            area = raio * n;
            Console.WriteLine("A=" +  area.ToString("F4",CultureInfo.InvariantCulture));
            
            
                
        }
    }
}
