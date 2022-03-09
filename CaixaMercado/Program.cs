using System;
using CaixaMercado.src.entities;
namespace CaixaMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Banana";
            double valor = 0.99;
            int tipo = 2;
            Produto produto1 = new Produto(nome, valor, tipo);

            Caixa caixa = new Caixa();

            Console.WriteLine($"Nome: {nome} \nValor Total: {caixa.calculaValorFinal(produto1, 3):C2}");

            nome = "Energético";
            valor = 5.49;
            tipo = 3;
            Produto produto2 = new Produto(nome, valor, tipo);
            Console.WriteLine($"Nome: {nome} \nValor Total: {caixa.calculaValorFinal(produto2, 7):C2}");

            nome = "Arroz";
            valor = 20.00;
            tipo = 1;            
            Produto produto3 = new Produto(nome, valor, tipo);
            Console.WriteLine($"Nome: {nome} \nValor Total: {caixa.calculaValorFinal(produto3, 1):C2}");
            
            nome = "Chocolate";
            valor = 4.50;
            tipo = 1;
            Produto produto4 = new Produto(nome, valor, tipo);
            Console.WriteLine($"Nome: {nome} \nValor Total: {caixa.calculaValorFinal(produto4, 12):C2}");
            nome = "Leite";
            valor = 3.73;
            tipo = 3;
            Produto produto5 = new Produto(nome, valor, tipo);
            Console.WriteLine($"Nome: {nome} \nValor Total: {caixa.calculaValorFinal(produto5, 5):C2}");
            nome = "Abacaxi";
            valor = 2.40;
            tipo = 2;
            Produto produto6 = new Produto(nome, valor, tipo);
            Console.WriteLine($"Nome: {nome} \nValor Total: {caixa.calculaValorFinal(produto6, 1):C2}");

        }
    }
}
