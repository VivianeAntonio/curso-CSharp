// using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
      
        public Cliente Titular { get; set; }

        //a propriedade static indica que todos os objetos da classe ContaCorrente compartilham essa mesma informação
        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }         
        public int Numero { get; set; } 


        private double _saldo = 100;

        //criando propriedade
        //get retorna valor
        //set define o valor
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {               
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
       
        //Este construtor indica que é obrigatório na ContaCorrente ter nº da conta e agencia
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        // a função var ter um return do tipo bool
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        // void é uma função sem retorno
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}

