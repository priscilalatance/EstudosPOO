namespace TrabalhandoComListas.src.entities
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        
        public Pessoa(string nome, int idade) 
        {
            this.nome = nome;
            this.idade = idade;

        }
    }
}