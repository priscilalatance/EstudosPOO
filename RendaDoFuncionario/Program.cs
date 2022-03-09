using System;
using RendaDoFuncionario.src.entities;

namespace RendaDoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Funcionário.");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();
            Console.Write("Salario Mensal: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Data de Admissão: ");
            DateTime dataAdmissao = DateTime.Parse(Console.ReadLine());
            Console.Write("CPF: ");
            string CPF = Console.ReadLine();
            Console.Write("Funcionário obteve aumento de salário esse ano? ");
            string aumentoSalario = Console.ReadLine();
            double aumento = 0;
            Funcionario funcionario = new Funcionario(nome, matricula, salario, dataAdmissao, CPF);
            if(aumentoSalario == "Sim")
            {
                Console.Write("Valor de aumento: ");
                aumento = double.Parse(Console.ReadLine());
                funcionario.receberAumento(aumento);              

            }                               
            Console.WriteLine($"Salário Bruto Anual: {funcionario.calcularGanhoBrutoAnual():C2}.");
            Console.WriteLine($"Salário Líquido Mensal: {funcionario.calcularGanhoLiquidoMensal():C2}.");
            Console.WriteLine($"Imposto pago anualmente: {funcionario.calcularImposto():C2}.");
            Console.WriteLine($"Salário Líquido Anual: {funcionario.calcularGanhoLiquidoAnual():C2}.");
            
        }
    }
}
