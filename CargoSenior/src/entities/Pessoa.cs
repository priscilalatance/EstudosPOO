using System;

namespace CargoSenior.src.entities
{
    public class Pessoa
    {
        private string nome { get; set; }
        private string cargo { get; set; }

        public void listaCargos(){
            int starter = 0, junior = 0, senior =0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Informe o nome da {i}° pessoa:");
                nome = Console.ReadLine();
                Console.Write($"Informe o cargo da {i}° pessoa (Starter, Junior ou Sênior):");
                cargo = Console.ReadLine();

                if (cargo == "Starter")
                {
                    starter++;
                }
                else if(cargo == "Junior")
                {
                    junior++;
                }
                else
                {
                    senior++;
                }
            }
            Console.WriteLine($"\nTotal de pessoas\nStarter: {starter}\nJunior: {junior}\nSênior: {senior}");
        }
    }

}