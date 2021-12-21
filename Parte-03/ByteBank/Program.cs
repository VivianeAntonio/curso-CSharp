using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);
            carlos.Nome = "Carlos";
            carlos.CPF = " 541.698.854-20";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.ReadLine();
        }
    }
}
