using System;
namespace Exercicio2.Models
{
    public class Livro : Produto, Iimposto
    {
        public Livro(string nome, double preco, int qtd,string autor,string tema, int qtPag) : base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.qtdPag = qtdPag;
            this.nome = nome;
            this.preco = preco;
        }

        public string Autor { get; set; }
        public string Tema { get; set; }
        public int qtdPag { get; set; }

        public Livro()
        {

        }
        public void CalculaImposto()
        {
            if (Tema.Equals("educativo"))
            {   
                Console.WriteLine($"O livro {nome} é educativo portanto não contém taxas! Permaneceu em um valor de: R${preco} reais.");
            }
            else
            {
                double imposto = (preco * 10)/100;
                preco = preco + imposto;
                Console.WriteLine($"O livro  {nome} contém taxas! e ficou em um valor de: {preco} reais.");
            }
        }
    }
}