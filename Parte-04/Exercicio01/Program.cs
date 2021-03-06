using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
                Console.WriteLine("Exceção tratada.");
            }
            Console.ReadLine();
        }
        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }            
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
