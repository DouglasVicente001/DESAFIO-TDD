using System;
using Exercicio1.Models;
using static System.Console;
namespace Exercicio1
{
      public class TelaAtividade1
      {
            public void telaAtividade()
            {      
                while(true)
                {
                  Veiculo veiculo = new Veiculo("gol","voks","5454","azul",55,40,20,false);
                  veiculo.Acelerar();
                  veiculo.Abastecer(65);
                  veiculo.Frear();
                  veiculo.Pintar("vermelho");
                  veiculo.Ligar();
                  veiculo.Desligar();
                
                WriteLine("\nDeseja sair da atividade 1 veiculo e retornar ao MENU?  [S] / [N]");
                string saida = ReadLine();

                if (saida.Equals("s",StringComparison.InvariantCultureIgnoreCase))
                {
                    WriteLine("Saindo da atividade 1. Obrigado ");
                    break;
                }
                }
            }   
      }
}
      