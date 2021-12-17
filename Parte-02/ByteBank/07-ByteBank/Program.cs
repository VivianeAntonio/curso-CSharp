using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            ContaCorrente conta = new ContaCorrente(575, 00584698);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(575, 12453685);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();
        }
    }
}
