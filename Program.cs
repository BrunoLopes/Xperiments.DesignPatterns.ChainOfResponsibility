using System;
using Xperiments.DesignPatterns.ChainOfResponsibility.Models;

namespace Xperiments.DesignPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();

            Orcamento orcamento = new Orcamento(501);
            orcamento.AdicionaItens(new Item("Caneta", 20));
            orcamento.AdicionaItens(new Item("Lápis", 15));
            orcamento.AdicionaItens(new Item("Borracha", 3));
            orcamento.AdicionaItens(new Item("Caderno", 300));
            orcamento.AdicionaItens(new Item("Mochila", 200));
            orcamento.AdicionaItens(new Item("6º elemento", 1));
            
            double desconto = calculadora.Calcula(orcamento);
            
            Console.WriteLine(desconto);
            
        }
    }
}
