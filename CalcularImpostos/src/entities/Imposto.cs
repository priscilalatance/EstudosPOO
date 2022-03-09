namespace CalcularImpostos.src.entities
{
    public interface Imposto
    {
         public double valor { get; set; }

         public double CalcularImpostos(double valor);
    }
}