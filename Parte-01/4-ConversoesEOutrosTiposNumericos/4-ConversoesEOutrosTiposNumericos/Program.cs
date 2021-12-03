using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;
            Console.WriteLine(salario);

            //VARIÁVEIS DO TIPO INTEIRO

            //O int é uma variável que suporta até 32 bits
            int salarioEmInteiro = (int)salario; //Forçando a double a receber o tipo int
            Console.WriteLine(salarioEmInteiro);

            //O long é uma variável de até 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // O tipo short é uma variável de até 16 bits
            short quantidadeProdutos = 30000;
            Console.WriteLine(quantidadeProdutos);

            //VARIÁVEIS DO TIPO PONTO FLUTUANTE

            //Float apesar de ser como o double, precisa ser explicitamente colocado um sufixo f
            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.ReadLine();

        }
    }
}
