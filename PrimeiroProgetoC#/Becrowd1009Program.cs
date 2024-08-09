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
        //Faça um programa que leia o nome de um vendedor, o seu salário
        //fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de 
        //comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

        //Entrada
        //O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla
        //precisão (double) com duas casas decimais, representando o salário fixo do vendedor e 
        //montante total das vendas efetuadas por este vendedor, respectivamente.

        //Saída
        //Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
        //exemplos  entrada: JOAO                        saida: TOTAL = R$ 684.54
        //                   500.00
        //                   1230.30

        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, bonus, salarioTotal;
            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            bonus = vendas * 15 / 100;
            salarioTotal = salario + bonus;
            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
