using System;
using CalcularImpostos.src.entities;
namespace CalcularImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor:");
            double valor = Double.Parse(Console.ReadLine());
            double valorIcms, valorIpi, valorCofins;
            IPI ipi = new IPI();
            ICMS icms = new ICMS();
            COFINS cofins = new COFINS();
            valorIcms = icms.CalcularImpostos(valor);
            valorIpi = ipi.CalcularImpostos(valor);
            valorCofins = cofins.CalcularImpostos(valor);

            Console.WriteLine($"ICMS: {valorIcms}:F1");
            Console.WriteLine($"IPI: {valorIpi}:F1");
            Console.WriteLine($"COFINS: {valorCofins}:F1");
            Console.WriteLine($"Valor Total: {(valorIcms + valorIpi + valor + valorCofins):F1}");

        }
    }
}
