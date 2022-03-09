namespace CalcularImpostos.src.entities
{
    public class COFINS : Imposto
    {
        public double valor { get; set; }

         public double CalcularImpostos(double valor){
            if (valor > 17000)
            {
                return valor * 0.08;                   
            }
            else
            {
                return 0;   
            }

        }
    }
}