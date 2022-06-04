namespace Exercicio2.Models
{
    public abstract class Produto 
    {
            protected Produto(string nome, double preco, int qtd)
            {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
            }
        public string nome { get; set; }
        public double preco { get; set; }
        public int qtd { get; set; }
        
        public Produto()
        {
            
        }
    }
}