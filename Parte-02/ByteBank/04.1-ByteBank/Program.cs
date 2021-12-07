using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios práticos");

            ContaCorrente contaDaViviane = new ContaCorrente();
            ContaCorrente contaDoAntonio = new ContaCorrente();

            contaDaViviane.Depositar(1000);
            contaDoAntonio.Depositar(2000);

            Console.WriteLine("Conta da Viviane: " + contaDaViviane.saldo);
            Console.WriteLine("Conta do Antonio: " + contaDoAntonio.saldo);

            contaDoAntonio.Transferir(500, contaDaViviane);

            Console.WriteLine("Conta da Viviane: " + contaDaViviane.saldo);
            Console.WriteLine("Conta do Antonio: " + contaDoAntonio.saldo);

            contaDaViviane.Sacar(300);

            Console.WriteLine("Conta da Viviane: " + contaDaViviane.saldo);
            Console.WriteLine("Conta do Antonio: " + contaDoAntonio.saldo);

            contaDaViviane.Transferir(200, contaDoAntonio);

            Console.WriteLine("Conta da Viviane: " + contaDaViviane.saldo);
            Console.WriteLine("Conta do Antonio: " + contaDoAntonio.saldo);


            Console.ReadLine(); 
        }
    }
}
