namespace CaixaMercado.src.entities
{
    public class Caixa 
    {


        public double calculaValorFinal(Produto produto , int quantidade){
            double valorTotal = quantidade * produto.valor;
            
            if (produto.tipo == 1)
            {
                return valorTotal - (valorTotal * 0.10);
            }
            else if (produto.tipo == 2)
            {
                return valorTotal - (valorTotal * 0.20);
            }
            else if(produto.tipo == 3 && quantidade > 5)
            {
                return valorTotal - (valorTotal * 0.10);                   
            }
            else
                return valorTotal;

        }
    }
}