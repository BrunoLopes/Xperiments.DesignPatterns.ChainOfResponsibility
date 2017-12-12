using System.Collections.Generic;

namespace Xperiments.DesignPatterns.ChainOfResponsibility.Models
{

    public class Orcamento
    {
        public double Valor { get; private set; }
        
        public List<Item> Itens { get; private set;}

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }
        
        public void AdicionaItens(Item item)
        {
            Itens.Add(item);
        }
    }


}


