using System;
using System.Linq;

namespace ListaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int acima10 = 0, acima50 = 0, menor, maior, i;
            string ac10 = string.Empty, ac50 = string.Empty;

            for (i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

                if(numeros[i] > 10){
                    ac10 += numeros[i]+" ";
                    acima10++;
                }
                if(numeros[i] > 50){
                    ac50 += (numeros[i]+" ");
                    acima50++;
                }
            }
            Array.Sort(numeros);
            Console.WriteLine($"Número menor: {menor = numeros[numeros.GetLowerBound(0)]}");
            Console.WriteLine($"Número maior: {maior = numeros[numeros.GetUpperBound(0)]}");
            Console.WriteLine($"Média dos valores: {numeros.Average()}");
            Console.Write($"Quantidade de números acima de 10: {acima10}. Numeros: {ac10}");

            Console.Write($"\nQuantidade de números acima de 50: {acima50}. Numeros: {ac50}");

        }
    }
}
