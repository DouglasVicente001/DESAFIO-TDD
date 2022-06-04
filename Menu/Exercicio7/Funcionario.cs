using System;
namespace Exercicio7.Models
{
    public abstract class Funcionario
    {
        public Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public abstract void  Bonificação();
    }
}