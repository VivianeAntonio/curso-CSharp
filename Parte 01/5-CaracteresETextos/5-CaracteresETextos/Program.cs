using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e textos");

            //Correto! Lembre-se: uma string é declarada com aspas duplas " e pode ter zero ou mais caracteres. Um char é declarado com aspas simples ' e pode usar apenas um caractere!

            //character utiliza-se aspas simples ' '
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //ascii table é a representação numérica para cada caracter (Ex: 65 = A)
            primeiraLetra = (char)65; // conversão do type casting
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //string é usado na representação de texto
            string titulo = "Alura cursos de tecnologia " + 2021;
            Console.WriteLine(titulo);

            //utilizamos @ para quebra de linha nas strings
            string cursosProgramacao =
@"- .NET
- Java
- Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
