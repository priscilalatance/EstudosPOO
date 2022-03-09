using System;

namespace ContarLetrasUltimaPalavra
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frase = Console.ReadLine().Split(" ");
            int i = frase.Length-1;
            Console.WriteLine(frase[i].Length);
        }
    }
}
