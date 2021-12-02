//operador OU ||
//operador E &&
//operador IGUALDADE ==
//

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

            int idadeJoao = 20;
            //int quantidadePessoas = 1;
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;
                        
            if (idadeJoao >= 18 && acompanhado == true)
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
