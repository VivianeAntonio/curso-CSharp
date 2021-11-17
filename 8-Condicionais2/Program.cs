//operador OU ||
//operador E &&

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2 ");

            int idadeJoao = 10;
            int quantidadePessoas = 3;
                        
            if (idadeJoao >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }


            Console.ReadLine();
        }
    }
}
