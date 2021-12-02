using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo");

            int idadeJoao = 20;            
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == false)
	        {
                 mensagemAdicional = "João está acompanhado.";
	        }else
	        {
                mensagemAdicional = "João NÃO está acompanhado.";
	        }
                        
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }


            Console.ReadLine();
        }
    }
}
