using System;

namespace MaiorNumeroSequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inteiros = Console.ReadLine().Split(" ");;
            string retorno = string.Empty;
            int total = 0, n=0, maior=0;

            for(int i = 0; i < inteiros.Length; i++){
                n = Convert.ToInt16(inteiros[i]);
                total += n;
                if(n > maior){
                    maior = n;
                }
            }
            Console.WriteLine($"O maior número é {maior}");
            Console.WriteLine($"A soma dos valores é {total}");
        }
    }
}
