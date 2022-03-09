namespace ExercicioPOO___Copia.src.Entities
{
    public class VideoGame : Produto, Imposto
    {
        private string marca;
        private string modelo;
        private bool isUsado;

        public VideoGame(){

        }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado){
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }
        public double calculaImposto(){
            if(isUsado == true)
            {
                return Preco * 0.25;
            }
            else
            {
                return Preco * 0.45;
            }            
        }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public bool IsUsado { get => isUsado; set => isUsado = value; }
    }
}