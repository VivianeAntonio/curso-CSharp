using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoCaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRING USA ASPAS "DUPLAS", CHAR USA ASPAS 'SIMPLES'

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)80;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string nome = "Viviane Antonio da Silva " + valor + 1;
            Console.WriteLine(nome);
            Console.ReadLine();
        }
    }
}
