using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(256, 85648);

            new ContaCorrente(156, 8745);

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
