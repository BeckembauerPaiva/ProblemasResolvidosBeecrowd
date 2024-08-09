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
        //Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o
        //valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e
        //o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

        //Entrada
        //O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores,
        //respectivamente dois inteiros e um valor com 2 casas decimais.

        //Saída
        //A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando
        //de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser
        //apresentado com 2 casas após o ponto.
        // exemplos entrada: 12 1 5.30              saida:VALOR A PAGAR: R$ 15.50
        //                   16 2 5.10

        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int codPeca = int.Parse(vet[0]);
            int numPeca = int.Parse(vet[1]);
            double valorUnitarioDaPeca = double.Parse(vet[2]);

            String[] vet2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(vet2[0]);
            int numPeca2 = int.Parse(vet2[1]);
            double valorUnitarioDaPeca2 = double.Parse(vet2[2]);

            double soma1 = numPeca * valorUnitarioDaPeca;
            double soma2 = numPeca2 * valorUnitarioDaPeca2;

            double totalPagar = soma1 + soma2;
            Console.WriteLine("VALOR A PAGAR: = R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
