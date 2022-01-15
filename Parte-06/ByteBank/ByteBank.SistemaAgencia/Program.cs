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

            String texto = "Gustavo_Silva";

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("String vazia");
            }

            Int32 indice2 = texto.IndexOf("Gustavo");
            String texto2 = texto.Substring(indice2 + 1);

            Console.WriteLine("Tamanho: " + texto.Length);
            Console.WriteLine("Indice: " + indice2);
            Console.WriteLine(texto2);
            Console.ReadLine();




            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento " + nomeArgumento.Length);
            Console.WriteLine(palavra);

            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));

            Console.ReadLine();

            string textoVazio = "fgdfd";
            String textoNulo = null;
            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));


            string url = "pagina?argumentos";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
                      
            Console.ReadLine();
        }
    }
}
