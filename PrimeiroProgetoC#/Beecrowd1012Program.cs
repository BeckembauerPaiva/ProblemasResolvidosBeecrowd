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
        //Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
        //a) a área do triângulo retângulo que tem A por base e C por altura.
        //b) a área do círculo de raio C. (pi = 3.14159)
        //c) a área do trapézio que tem A e B por bases e C por altura.
        //d) a área do quadrado que tem lado B.
        //e) a área do retângulo que tem lados A e B.
        //Entrada
        //O arquivo de entrada contém três valores com um dígito após o ponto decimal.

        //Saída
        //O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das
        //áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois 
        //pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
        //EXEMPLOS  ENTRADA 3.0 4.0 5.2                            saida TRIANGULO: 7.800
        //                                                               CIRCULO: 84.949
        //                                                               TRAPEZIO: 18.200
        //                                                               QUADRADO: 16.000
        //                                                               RETANGULO: 12.000

            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            double triangulo, circulo, trapezio, quadrado, retangulo;
            triangulo = a * c / 2;
            circulo = 3.14159 * (c * c);
            trapezio = ((a + b) * c) / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
