using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            double raio, pi,volume;
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            pi = 3.14159;
            volume = (4.0/3.0) * pi * (raio * raio * raio);
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
            
        }
    }
}
