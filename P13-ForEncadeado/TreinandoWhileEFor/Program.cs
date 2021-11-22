using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoWhileEFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Treinando While e For");
            
            //Exercício For
            Console.WriteLine("Escreva um laço for que imprima os números de 0 a 10");
            for (int contadorFor = 0; contadorFor <= 10; contadorFor ++)
                Console.WriteLine(contadorFor);

            //Exercício While
            Console.WriteLine("Escreva um laço while que imprima os números de 0 a 10");
            int contadorWhile = 0;
            while (contadorWhile <= 10)
            {

                Console.WriteLine(contadorWhile);
                contadorWhile++;
            }

                Console.ReadLine();
        }
    }
}
