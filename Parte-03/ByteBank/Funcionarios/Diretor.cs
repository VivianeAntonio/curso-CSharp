using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Herança usando : diretor herda propriedades da classe funcionario
    public class Diretor : Funcionario
    {
       
        public double GetBonificacao()
        {            
            return Salario;
        }

    }
}
