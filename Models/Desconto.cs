namespace Xperiments.DesignPatterns.ChainOfResponsibility.Models
{
    public interface Desconto 
    {
    Desconto Proximo {get; set;} 
    
    double Desconta(Orcamento orcamento);
    
    }

}