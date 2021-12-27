using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("452.659.225-06");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("956.740.045-50");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("856.895.456-90");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("452.659.225-06");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("363.562.451-51");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("956.740.045-50");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("154.652.024-01");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês: " + 
                gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
