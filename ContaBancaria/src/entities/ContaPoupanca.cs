namespace ContaBancaria.src.entities
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }
        public override double rendimentoConta()
        {
            return saldo * 0.07;
        }
    }
}