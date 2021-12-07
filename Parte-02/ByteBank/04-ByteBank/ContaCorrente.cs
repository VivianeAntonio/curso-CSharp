public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    // a função var ter um return do tipo bool
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    // void é uma função sem retorno
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

}
