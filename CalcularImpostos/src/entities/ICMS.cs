namespace CalcularImpostos.src.entities
{
    public class ICMS : Imposto
    {
        public double valor { get; set; }

         public double CalcularImpostos(double valor){
             return valor * 0.30;
        }
    }
}