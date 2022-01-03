using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();


            Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;

            try
            {
                leitor = new LeitorDeArquivo("contasl.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch(IOException)
            {
                
                Console.WriteLine("Excecao do tipo IOException capturada e tratada.");
            }
            finally
            {
                if(leitor != null)
                {
                    leitor.Fechar();
                }
                
            }
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(452, 54875);
                ContaCorrente conta2 = new ContaCorrente(575, 36447);

                //conta1.Transferir(100000, conta2);
                conta1.Sacar(100000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informacoes da INNER EXCEPTION (execao interna)");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {            
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);           
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero= " + numero + " e divisor= " + divisor);
                throw;  //controle de fluxo semelhante a return                
            }            
        }
    }
}
