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
        //Escreva um programa que leia o número de um funcionário, seu número de horas
        //trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
        //A seguir, mostre //o número e o salário do funcionário, com duas casas decimais.

        //Entrada
        //O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais,
        //representando o número, quantidade de horas trabalhadas e o valor que o funcionário
        //recebe //por hora trabalhada, respectivamente.

        //Saída
        //Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço
        //em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço //em branco após o $.
        // exemplo: entrada 25          saida:NUMBER = 25
        //                  100                     SALARY = U$ 550.00
        //                  5.50 


        static void Main(string[] args)
        {
            int numeroFuncionario, horas, saidaNumeroFuncionario;
            double salario, saidaSalario;
            numeroFuncionario = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            saidaNumeroFuncionario = numeroFuncionario;
            saidaSalario = horas * salario;
            Console.WriteLine("NUMBER = " + saidaNumeroFuncionario);
            Console.WriteLine("SALARY = U$ " + saidaSalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
