using System;
using ContaBancaria.src.entities;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBem Vindo ao Banco Nubank!\n");
            Console.Write("Títular: ");
            string titular = Console.ReadLine();
            Console.Write("Número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Saldo para investimento: ");
            double saldo = double.Parse(Console.ReadLine());

            ContaCorrente contaCorrente = new ContaCorrente(numero, titular, saldo);
            ContaPoupanca contaPoupanca = new ContaPoupanca(numero, titular, saldo);
            
            Console.WriteLine($"\nResultado de rendimento na Conta Corrente: {contaCorrente.rendimentoConta():C2}.");
            Console.WriteLine($"\nResultado de rendimento na Poupança: {contaPoupanca.rendimentoConta():C2}.");
        }
    }
}
