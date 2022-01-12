using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(658, 74569);
            Console.WriteLine(conta.Saldo);

            new ContaCorrente(541, 752);

            conta.Sacar(50);
            Console.WriteLine(conta.Saldo);

            string nome = "Viviane";

            Console.ReadLine();
        }
    }
}
