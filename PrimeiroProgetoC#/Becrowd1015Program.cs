using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no
            //plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais,
            //segundo a fórmula:

            //Distancia =

            //Entrada
            //O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto
            //flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 //y2.

            //Saída
            //Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.
            //exemplos  entrada:1.0 7.0               saida:4.4721
            //                  5.0 9.0

            double x1,x2,y1,y2,distancia;

            string[] valores1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores1[0],CultureInfo.InvariantCulture);
            y1 = double.Parse(valores1[1], CultureInfo.InvariantCulture);

            string[] valores2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));




       }
    }
}