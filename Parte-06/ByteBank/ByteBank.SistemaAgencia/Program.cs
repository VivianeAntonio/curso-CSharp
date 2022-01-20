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
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor moedaOrigem: " + valorMoedaOrigem);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor moedaDestino: " + valor);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();









            // testando ToLower()
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            // testando Replace
            termoBusca = termoBusca.Replace("r", "R");
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace("a", "A");
            Console.WriteLine(termoBusca);


            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();







            // testando o metodo remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf("&");
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();








            string palavra = "moedaOrigem=real&moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento " + nomeArgumento.Length);
            Console.WriteLine(palavra);

            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

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