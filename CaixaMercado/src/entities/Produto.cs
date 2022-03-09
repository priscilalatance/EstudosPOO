namespace CaixaMercado.src.entities
{
    public class Produto
    {
        public string nome { get; set; }

        public double valor { get; set; }
        public int tipo { get; set; }

        public Produto(string nome, double valor, int tipo)
        {
            this.nome = nome;
            this.valor = valor;
            this.tipo = tipo;
        }

    }
}