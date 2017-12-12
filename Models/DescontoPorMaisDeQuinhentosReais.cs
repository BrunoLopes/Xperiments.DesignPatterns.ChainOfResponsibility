namespace Xperiments.DesignPatterns.ChainOfResponsibility.Models
{
        
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto Proximo  {get; set;}
            
        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Valor > 500)
            return orcamento.Valor * 0.7;
            
            return Proximo.Desconta(orcamento);
        }
        
    }
}