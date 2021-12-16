// using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
      
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }         
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

