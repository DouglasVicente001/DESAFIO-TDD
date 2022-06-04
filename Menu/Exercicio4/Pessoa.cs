using System.Collections.Generic;
namespace Exercicio4.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {   
            string str = "";
            str += $"Nome: {Nome} | Idade: {Idade}\n";
            return  str;
        }

    }
}