using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;


namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];

            for(int i = 0; i <= 4 ;i++)
            {
                vetor[i] =int.Parse(ReadLine());
            }
            Array.Sort(vetor);
            int menor = vetor[vetor.GetLowerBound(0)];
            int maior = vetor[vetor.GetUpperBound(0)];

            WriteLine(menor);
            WriteLine(maior);
            Console.WriteLine(vetor.Average());
            int qtdadeIguais = vetor.Length - vetor.ToList().Distinct().Count();
            WriteLine(qtdadeIguais);
            if(qtdadeIguais == 4)
            {
                WriteLine("Numeros são iguais");
            }
        }
    }
}
