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
            //Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor
            //unitário de cada peça 1, o código de uma peça 2,
            //o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

            //Entrada
            //O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente
            //dois inteiros e um valor com 2 casas decimais.

            //Saída
            //A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço
            //após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
            // exemplos  entrada: 3              saida:VOLUME = 113.097

            double raio, pi,volume;
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            pi = 3.14159;
            volume = (4.0/3.0) * pi * (raio * raio * raio);
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
            
        }
    }
}
