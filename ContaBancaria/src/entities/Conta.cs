namespace ContaBancaria.src.entities
{
    public abstract class Conta
    {
        private int numero { get; set; }
        private string titular { get; set; }
        public double saldo { get; set; }

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public virtual double rendimentoConta(){
            return 0;
        }

    }
}