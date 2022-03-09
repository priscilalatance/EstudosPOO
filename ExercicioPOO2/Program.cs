using System;
using static System.Console;
using ExercicioPOO___Copia.src.Entities;
using System.Collections.Generic;

namespace ExercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1= new Livro("Harry Poter", 40, 50, "J.K.Rowling", "fantasia", 300);
            Livro l2= new Livro("Senhor dos Anéis", 60, 30, "J.R.R.Tolkien", "fantasia", 500);
            Livro l3= new Livro("JAVA POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);
            WriteLine($"{l2.calculaImposto():C1} de impostos sobre o livro {l2.Nome}.");

            WriteLine($"Livro educativo não tem imposto: {(l3.calculaImposto() == 0? l3.Nome :"Não tem livro educativo" )}.");

            WriteLine($"Imposto {ps4Usado.Nome} {ps4Usado.Modelo} {(ps4Usado.IsUsado? "usado":"Não usado")}, {ps4Usado.calculaImposto():C1}.");
            WriteLine($"Imposto {ps4.Nome} {ps4.Modelo} {ps4.calculaImposto():C1}.");
            WriteLine("---------------------------------------------------------------------------------");            
            WriteLine("A loja Americanas possui estes livros para venda:");     
            americanas.listaLivros();
            WriteLine("---------------------------------------------------------------------------------");            
            WriteLine("A loja Americanas possui estes video-games para venda:");              
            americanas.listaVideoGame();
            WriteLine($"O patrimonio da loja: Americanas é de {americanas.calculaPatrimonio():C1}");



        }
    }
}
