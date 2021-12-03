using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 10;
            int quantidadePessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                if(quantidadePessoas >= 2){
                    Console.WriteLine("Você tem menos de 18, mas está acompanhado. Pode entrar.");
                   
                }
                else
                {
                    Console.WriteLine("Infelizmente, você não pode entrar");
                }
                
            }

            Console.ReadLine();
        }
    }
}
