using System.Collections.Generic;
using System.Linq;
using System;
using static System.Console;
namespace Exercicio2.Models.Entitites
{
    public class Loja
    {



        public Loja()
        {
            
        }
        public Loja(string nome, string cnpj, List<Livro> livros,List<VideoGame> videoGames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros= livros;
            this.videoGames = videoGames;
        }

            public Loja(string nome, string cnpj) 
        {
            this.nome = nome;
            this.cnpj = cnpj;
               
        }
        public string nome { get; set; }
        public string cnpj { get; set; }
        

        public List<Livro> livros;
        public List<VideoGame> videoGames;

        
        public void ListaLivros()
        {
            Console.WriteLine($"A loja {nome} possui estes livros para venda!");
            
            foreach (var livro in livros)
            {
                Console.WriteLine($"Titulo : {livro.nome}, preço: R$: {livro.preco} reais,quantidade em estoque {livro.qtd} unidades.");
                if (livros.Count == 0)
                {
                    
                    Console.WriteLine("A loja não tem livros no seu estoque.");
                }
              
            }

        }
        public void ListaVideoGames()
        {
            Console.WriteLine($"A loja {nome} possui estes videos-games para venda!");
            foreach (var games in videoGames)
            {   
                Console.WriteLine($"Modelo: {games.nome}, preço: R${games.preco} reais, quantidade em estoque {games.qtd} unidades.");
            
                if (livros.Count == 0)
                {
                    Console.WriteLine("A loja não tem video-games no seu estoque.");
                }
            }
        }
        public double CalculaPatrimonio()
        {   
            double somaGames = 0;
            double somaLivros = 0;

            for (int i = 0; i < videoGames.Count; i++)
            {
                somaGames += videoGames[i].preco * videoGames [i].qtd;
            }
            for (int i = 0; i < livros.Count; i++)
            {
                somaLivros += livros[i].preco * livros [i].qtd;
            }
            double total = somaLivros + somaGames;
            return total;
        }
        
    }
}