namespace Exercicio3.Models
{
    public abstract class Personagem
    {
        public Personagem(string nome, int vida, int mana, float xp,int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            Qtd ++;
        }

        public string Nome { get; protected set; }
        public int Vida { get; protected  set; }
        public int Mana { get; protected set; }
        public int Inteligencia { get; protected  set; }
        public float Xp { get; protected  set; }
        public int Forca { get; protected set; }
        public int Level { get; protected  set; }

        public static int Qtd { get; protected set; }
        public abstract void lvlUp();
        public abstract void attack();
        public abstract void aprenderMagia(string magia1,string magia2,string magia3);

    }
}