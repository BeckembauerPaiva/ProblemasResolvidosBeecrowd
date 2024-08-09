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
        //Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno.
        //A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5.
        //Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

        //Entrada
        //O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão(double).

        //Saída
        //Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito
        //após o ponto decimal e com um espaço em branco antes e depois da igualdade.Assim como todos os problemas, não
        //esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
        // exemplos  entrada 5.0 6.0 7.0   saida MEDIA = 6.3


        static void Main(string[] args)
        {
           double a,b,c,pesoA,pesoB,pesoC,media;
            a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pesoA = 2;
            pesoB = 3;
            pesoC = 5;
            media = ((a * pesoA) + (b * pesoB) + (c * pesoC)) / (pesoA + pesoB + pesoC);
            Console.WriteLine("MEDIA = " + media.ToString("F1",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
