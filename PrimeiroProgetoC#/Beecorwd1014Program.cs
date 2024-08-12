using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida
            //(em Km) e o total de combustível gasto (em litros).

            //Entrada
            //O arquivo de entrada contém dois valores: um valor inteiro X representando a distância
            //total percorrida (em Km), e um valor real Y representando o total de combustível gasto,
            //com um dígito após o ponto decimal.

            //Saída
            //Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula,
            //seguido da mensagem "km/l".
            //exemplos entrada: 500                             saida:14.286 km/l
            //                  35.0

            int distancia;
            double media, gasto;
            distancia = int.Parse(Console.ReadLine());
            gasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = distancia / gasto;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();

       }
    }
}