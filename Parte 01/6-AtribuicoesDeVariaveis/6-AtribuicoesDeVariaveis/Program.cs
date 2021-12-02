using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 20;
            int idadeViviane = idade;

            idade = 30;

            Console.WriteLine(idade);
            Console.WriteLine(idadeViviane);


            Console.ReadLine();
        }
    }
}
