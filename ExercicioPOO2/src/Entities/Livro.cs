using System;
namespace ExercicioPOO___Copia.src.Entities
{
    public class Livro : Produto, Imposto
    {
        private string autor;
        private string tema;
        private int qtdPag;


        public Livro(){

        }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag){
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        } 

        public double calculaImposto(){
            if(tema == "educativo")
            {
                return 0;
            }
            else
            {
                return Preco * 0.10;
            }

        }
        public string Autor { get => autor; set => autor = value; }
        public string Tema { get => tema; set => tema = value; }
        public int QtdPag { get => qtdPag; set => qtdPag = value; }
           
    }
}