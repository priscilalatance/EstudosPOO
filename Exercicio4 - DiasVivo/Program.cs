using System;
using static System.Console;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dataName = ReadLine().Split(" ");
            string name = dataName[0];
            int dia = int.Parse(dataName[1]);
            int mes = int.Parse(dataName[2]);          
            int ano = int.Parse(dataName[3]);

            DateTime dt = DateTime.Today;
            DateTime data2 = new DateTime(ano, mes, dia);

            WriteLine($"{name} viveu até hoje {dt.Subtract(data2).TotalDays} dias.");

        }
    }
}
