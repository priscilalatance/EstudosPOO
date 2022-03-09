namespace ContaBancaria.src.entities
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }
        public override double rendimentoConta()
        {
            return saldo * 0.05;
        }
    }
}