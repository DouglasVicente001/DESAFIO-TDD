using Exercicio4.Models;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Exercicio4
{
      public class TelaAtividade4
      {
            public void TelaAtividade4_6()
            {
                while(true)
                {
                Pessoa p1 = new Pessoa("Joao",15);
                Pessoa p2 = new Pessoa("Leandro",21);
                Pessoa p3 = new Pessoa("Paulo",17);
                Pessoa p4 = new Pessoa ("Jessica",18);

                
                List<Pessoa> lista = new List<Pessoa>();
                lista.Add(p1);
                lista.Add(p2);
                lista.Add(p3);
                lista.Add(p4);

                WriteLine("" + String.Join("",lista));

                lista = lista.OrderByDescending(pessoa => pessoa.Idade) .ToList();

                lista = lista.Where(pessoa => pessoa.Idade >=18) .ToList();

                string list  = lista.Any(pessoa => pessoa.Nome ==  "Jessica").ToString();


                WriteLine("" + string.Join("",lista));  
                if (list.Equals(true))
                {
                    WriteLine("Jessica não existe no contexto atual");
                    
                }
                else 
                {
                    WriteLine("O nome Jessica existe no contexto atual!");
                }
                WriteLine("" + string.Join("",list));
                
                WriteLine("Deseja voltar ao MENU? Pressione   [S] / [N]");
                string saida = ReadLine();

                if (saida.Equals("S",StringComparison.InvariantCultureIgnoreCase))
                {
                    WriteLine("Saindo da Atividade de Listas 4..6...Retornando ao MENU.");
                    break;
                }

                }
            }
      }
}