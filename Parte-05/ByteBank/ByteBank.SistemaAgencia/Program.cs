using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 02 , 28);
            DateTime dataCorrente = DateTime.Now;

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);

            TimeSpan diferenca = TimeSpan.FromMinutes(60);

            string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
