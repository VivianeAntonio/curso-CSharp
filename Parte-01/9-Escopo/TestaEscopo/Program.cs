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
            Console.WriteLine("Calculo de Imposto de Renda 2021");

            // Até 1900.0 o IR é de 0% e não é obrigatório contibuir
            // De 1900.1 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
            // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
            // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636
            // Acima de R$ 4664.1 o IR é de 27.5% e pode deduzir R$ 869


            double salario = 2700.0;

            if (salario <= 1900.0)
            {
                Console.WriteLine("A sua aliquota é de 0%");
                Console.WriteLine("Você não precisa declarar IR");
            }            
            else if (salario >= 1900.1 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ 142");
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }
            else if (salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$ 636");
            }
            else if (salario >= 4664.1)
            {
                Console.WriteLine("A sua aliquota é de 27.5%");
                Console.WriteLine("Você pode deduzir até R$ 869");
            }


            Console.ReadLine();
        }
    }
}
