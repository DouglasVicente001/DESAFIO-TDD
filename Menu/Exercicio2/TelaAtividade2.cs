using Exercicio2.Models;
using System;
using System.Collections.Generic;
using Exercicio2.Models.Entitites;
using static System.Console;

namespace Exercicio2
{
      class TelaAtividade2
      {
            public void telaAtividade2()
            {     
                  while(true)
                  {
                  Livro l1 = new Livro ("Harry potter",40,50,"sei la","fantasia",300);
                  Livro l2 = new Livro ("Cidades Mortas",60,30,"Dener Batista","Terror",500);
                  Livro l3 = new Livro ("Curso GFT",20,50,"Clecio","educativo",500);
                  
                  VideoGame ps4 = new VideoGame("ps4",1800,100,"Sony","Slim",false);
                  VideoGame ps4Usado = new VideoGame("ps4",1000,7,"Sony","Slim",true);
                  VideoGame xbox = new VideoGame("Xbox",1500,500,"Microsoft","one",false);

                  List <Livro> livros = new List<Livro>();
                  livros.Add(l1);
                  livros.Add(l2);
                  livros.Add(l3);

                  List <VideoGame> videoGames = new List<VideoGame>();
                  videoGames.Add(ps4);
                  videoGames.Add(ps4Usado);
                  videoGames.Add(xbox);

                  Loja americanas = new Loja ("americanas","545145524", livros,videoGames);

                  double valor = americanas.CalculaPatrimonio();
                  l3.CalculaImposto();
                  l1.CalculaImposto();
                  l2.CalculaImposto();
                  ps4.CalculaImposto();
                  ps4Usado.CalculaImposto();
                  WriteLine("---------------------------------------------------------------------------------------------------------");
                  americanas.ListaLivros();
                  WriteLine("---------------------------------------------------------------------------------------------------------");
                  americanas.ListaVideoGames();
                  WriteLine("---------------------------------------------------------------------------------------------------------");
                  
            
                  WriteLine($"Patrimônio total da loja {americanas.nome} é: R${valor:F3} Reais");

                  WriteLine("Você deseja sair do aplicativo americanas? [S] / [N]");
                  string opcao = ReadLine();

                  if(opcao.Equals("s",StringComparison.InvariantCultureIgnoreCase))
                  {
                        WriteLine("Saindo do app e retornando ao MENU... Obrigado por usar a loja!");
                        break;
                  }
                  }
            }
      }
}