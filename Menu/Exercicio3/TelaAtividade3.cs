using Exercicio3.Models;
using static System.Console;
using System.Collections.Generic;
namespace Exercicio3
{
      class TelaAtividade3
      {
            public void telaAtividade3()
            {     
                        string mensagem = "\nBEM VINDO AO RPG MONSTERFORCE" + 
                        "\nEscolha uma das opções a seguir:"+
                        "\n--------------------------------------------"+
                        "\nVer personagem MAGO. PRESSIONE [1]"+
                        "\nVer personagem GUERREIRO PRESSIONE [2]"+
                        "\nVer personagem ASSASINO. PRESSIONE [3]"+
                        "\nVer personagem ARQUEIRO. PRESSIONE [4]"+
                        "\nVer personagem BOSSFINAL. PRESSIONE [5]"+
                        "\nSair do jogo e retornar ao MENU. Pressione [6]";
                        WriteLine(mensagem);

                  
                  
                  while(true)
                  {  
                        int opcao = int.Parse(ReadLine());

                        switch (opcao)
                        {
                        case 1:
                              Mago mago = new Mago("Mago Negro",1500,2300,7000,300,65,45);
                              mago.attack();
                              mago.lvlUp();
                              mago.aprenderMagia("Bola de Fogo","Raio Mortífero","Circulo de Gelo");
                              mago.attack();
                              WriteLine(mensagem);
                              WriteLine($"Classe mago criada e adicionada ao Box quantidade de personagens: {Personagem.Qtd} ");
                        break;
                        
                        case 2:
                              Guerreiro guerreiro = new Guerreiro ("guerreiro das sombras",2000,500,6000,70,320,43);
                              guerreiro.attack();
                              guerreiro.lvlUp();
                              guerreiro.aprenderMagia("Chute Lateral","Choque Arcano","Espada Devastadora");
                              guerreiro.attack();
                              WriteLine(mensagem);
                              WriteLine($"Classe guerreiro criada e adicionada ao Box quantidade de personagens: {Personagem.Qtd} ");
                        break;

                        case 3:
                              Assasino assasino = new Assasino ("Ninja Hashirama",2450,1700,10000,110,288,55);
                              assasino.attack();
                              assasino.lvlUp();
                              assasino.aprenderMagia("Furtividade Absoluta","Corte Duplo","Golpe Letal");
                              assasino.attack();
                              WriteLine(mensagem);
                              WriteLine($"Classe assasino criada e adicionada ao Box quantidade de personagens: {Personagem.Qtd} ");
                        break;

                        case 4:
                              Arqueiro arqueiro = new Arqueiro ("Archer Mistophin",1600,1650,8000,278,288,47);
                              arqueiro.attack();
                              arqueiro.lvlUp();
                              arqueiro.aprenderMagia("Flecha Condutora","Salto Triplo","Sniper Transcedente");
                              arqueiro.attack();
                              WriteLine(mensagem);
                              WriteLine($"Classe arqueiro criada e adicionada ao Box quantidade de personagens: {Personagem.Qtd} ");
                        break;

                        case 5:
                              Boss bossFinal = new Boss ("DEMOM HUNTER BOSS",20000,4500,50000,1300,1250,99);
                              bossFinal.attack();
                              bossFinal.lvlUp();
                              bossFinal.aprenderMagia("Destruidor Terrestre","Explosão de Poder","Fora dos Limites");
                              bossFinal.attack();
                              WriteLine(mensagem);
                              WriteLine($"Classe BossFinal criada e adicionada ao Box quantidade de personagens: {Personagem.Qtd} ");
                        break;

                        case 6:
                              WriteLine("Você saiu do programa, obrigado por usar este RPG!");
                        break;

                        default:
                        WriteLine ("Opção inválida. Saindo...");
                        opcao = 6;
                        break;
                        }
                        
                  if (opcao == 6)
                  {
                        break;
                  }
                  }
            }
      }
}