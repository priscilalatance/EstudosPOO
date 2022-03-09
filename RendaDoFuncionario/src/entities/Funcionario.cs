using System;

namespace RendaDoFuncionario.src.entities
{
    public class Funcionario
    {
        private string nome { get; set; }
        private string matricula { get; set; }
        private double salario { get; set; }
        private DateTime dataAdmissao { get; set; }
        private string CPF { get; set; }

        public Funcionario(string nome, string matricula, double salario, DateTime dataAdmissao, string CPF)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.salario = salario;
            this.dataAdmissao = dataAdmissao;
            this.CPF = CPF;
        }

        public void receberAumento(double aumento){
            Console.WriteLine($"Funcionário teve aumento de {aumento:C2} esse ano.");
        }
        public double calcularGanhoBrutoAnual(){
            return salario * 12;
        }
        public double calcularImposto(){
            return calcularGanhoBrutoAnual() - calcularGanhoLiquidoAnual();
        }        
        public double calcularGanhoLiquidoMensal(){
            double inss = salario * 0.11;
            double IR = 0;
            if(salario > 2500)
            {
                IR = (salario - 2500 ) * 0.175;
            }
            return (salario - inss) - IR;
        }
        public double calcularGanhoLiquidoAnual(){
            return calcularGanhoLiquidoMensal() * 12;
        }

    }
}