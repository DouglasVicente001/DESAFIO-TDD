using static System.Console;
using System.Collections.Generic;
using System;
namespace Exercicio3.Models
{
      public class Assasino : Personagem
      {
        public Assasino(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        public override void lvlUp()
        {
            Vida = Vida +300;
            Mana = Mana +300;
            Inteligencia = Inteligencia +100;
            Forca = Forca +100;

            WriteLine($"\n*** Você upou de nível e os status foram evoluidos. Parabéns!***"+
            $"\n\n<STATUS DO PERSONGEM - ASSASINO>"+
            $"\nVida: {Vida} pontos.    +300 pontos pós nivel."+
            $"\nMana: {Mana} pontos.    +300 pontos pós nivel."+
            $"\nInteligencia: {Inteligencia} pontos.    +100 pontos pós nivel."+
            $"\nForça: {Forca} pontos.    +100 pontos pós nivel."); 
        }
        public override void attack ()
        {
            Random random = new Random();
            int recebeRandom = 0;
            recebeRandom = random.Next(0,300);
            recebeRandom += Forca * Level;
            WriteLine("\n==========================================================="+
            $"\nO attack de {Nome} foi de: {recebeRandom} de dano."+ "\n===========================================================");
        }
        public override void aprenderMagia(string magia1,string magia2,string magia3)
        {   
            WriteLine($"\n<ASSASINO SKILLS>" +
            $"\nPrimeiro attack: {magia1}." + $"\nSegundo attack: {magia2}."+ $"\nTerceiro attack: {magia3}");
        }
      }
}