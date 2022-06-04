using Exercicio7.Models;
using static System.Console;
using System;
namespace Exercicio7.Models
{
      public class TelaAtividade7
      {
            public void telaAtividade7()
            {
                  while(true)
                  {     
                        WriteLine("Funcionarios + Bonificações é igual a felicidade!\n");
                        Vendedor vendedor = new Vendedor ("Fernando",27,1300);
                        vendedor.Bonificação();
                        Supervisor supervisor = new Supervisor("Daniela",26,3500);
                        supervisor.Bonificação();
                        Gerente gerente = new Gerente ("Fabio",45,5000);
                        gerente.Bonificação();

                        WriteLine("Deseja sair da atividade 7?  [S] / [N] ");
                        
                        string opcao = ReadLine();
                        if (opcao.Equals("s",StringComparison.InvariantCultureIgnoreCase))
                        {
                              WriteLine("Saindo da atividade 7 e retornando ao MENU. Obrigado Clécio!");
                              break;
                        }
                  }
            }
        
      }
}