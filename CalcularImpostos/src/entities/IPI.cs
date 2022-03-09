namespace CalcularImpostos.src.entities
{
    public class IPI : Imposto
    {
        public double valor { get; set; }

         public double CalcularImpostos(double valor){
             if (valor < 25000)
             {
                return (valor * 0.05); 
             }
             else
             {
                return valor * 0.10; 
             }
                         
         }
           
    }
}