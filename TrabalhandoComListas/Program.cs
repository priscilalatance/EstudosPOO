using System;
using static System.Console;
using TrabalhandoComListas.src.entities;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoComListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa pessoa1 = new Pessoa("João", 15);
            Pessoa pessoa2 = new Pessoa("Leandro", 21);
            Pessoa pessoa3 = new Pessoa("Paulo", 17);
            Pessoa pessoa4 = new Pessoa("Jessica", 18);
            
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.nome} e tem {pessoa.idade} anos.");                
            }
            int quantidade = 0;

            foreach (var pessoa in pessoas)
            {
                quantidade++;                
            }
            WriteLine($"Quantidade de pessoas na lista: {quantidade}.");

            for (int pessoa = 0; pessoa < pessoas.Count; pessoa++)
            {
                    if(pessoa < 18){
                    pessoas.Remove(pessoas[pessoa]);
                    quantidade--;
                }     
            }
            WriteLine($"Quantidade de pessoas na lista: {quantidade}.");
 
            foreach (var pessoa in pessoas)
            {
                if(pessoa.nome == "Jessica"){
                    WriteLine("Jessica está na lista.");
                }                 
            }
        }
    }
}
