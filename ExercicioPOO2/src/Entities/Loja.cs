using System.Collections.Generic;
using System;
using System.Linq;


namespace ExercicioPOO___Copia.src.Entities
{
    public class Loja 
    {
        private string nome;

        private string cnpj;

        private List<Livro>livros;

        private  List<VideoGame>videoGames;
        

        public Loja(){

        }
        public Loja(string nome, string cnpj, List<Livro>livros, List<VideoGame>videoGames){
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Livros = livros;
            this.VideoGames = videoGames;

        }

        
        public string Nome { get => nome; set => nome = value; }

        public string Cnpj { get => cnpj; set => cnpj = value; }

        public List<Livro>Livros { get => livros; set => livros = value; }

        public  List<VideoGame>VideoGames { get => videoGames; set => videoGames = value; } 

        public void listaLivros(){

                try
                {
                    if(Livros.Count != 0)
                    {
                        foreach(var livro in Livros){
                            Console.WriteLine($"Título: {livro.Nome}, preço: {(livro.Preco):F1} , quantidade: {livro.Qtd} em estoque.");                       
                        }
                    }
                    else
                    {
                        throw new Exception("A loja não tem livros em estoque");
                    }  

                }
                catch (Exception vazio)
                {
                    Console.WriteLine($"Erro:{vazio.Message}");
                }

        }
        public void listaVideoGame(){
                try
                {
                    if(VideoGames.Count != 0)
                    {
                        foreach(var game in VideoGames){
                            Console.WriteLine($"Vídeo-game: {game.Marca}, preço: {(game.Preco):F1} , quantidade: {game.Qtd} em estoque.");                      
                        }
                    }
                    else
                    {
                        throw new Exception("A loja não tem video-games no seu estoque.");
                    }               

                }
                catch (Exception vazio)
                {
                    Console.WriteLine($"Erro:{vazio.Message}");
                }
        }
        public double calculaPatrimonio(){
             
            double valor= 0, valores=0;
            foreach (var livro in Livros)
            {
                valor += livro.Preco * livro.Qtd;
            }
            foreach (var videogame in VideoGames)
            {
                valores += videogame.Preco *  videogame.Qtd;
            }
             
             return valor + valores;

        }

    }
}