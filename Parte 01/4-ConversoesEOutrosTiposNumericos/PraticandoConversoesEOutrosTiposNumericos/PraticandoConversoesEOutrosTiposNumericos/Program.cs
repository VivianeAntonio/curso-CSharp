using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Podemos atribuir int dentro de double APENAS CONVERTENDO (int)
            //método conhecido como CASTING
            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            //No caso do float, poderíamos fazer o casting do mesmo jeito como no exemplo a seguir;
            //float pontoFlutuante = (float)3.14;
            //mas o usual é informar uma letra f no final:
            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);

            //Podemos atribuir um valor do tipo int dentro de uma variável do tipo double
            //ou seja, o inverso é válido
            int mesada = 100;
            double dinheiroLanche = mesada;
            Console.WriteLine(dinheiroLanche);

            Console.ReadLine();
        }
    }
}
