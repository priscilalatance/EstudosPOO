namespace ExercicioPOO___Copia.src.Entities
{
    public abstract class Produto
    {
        private string nome;
        private double preco;
        private int qtd;

        public Produto(){

        }

        public Produto(string nome, double preco, int qtd){
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }
        
        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Qtd { get => qtd; set => qtd = value; }

    }
}