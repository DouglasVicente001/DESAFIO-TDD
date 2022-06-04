using System;
namespace Exercicio7.Models
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            this.Salario = salario;
            this.Nome = nome;
            this.Idade = idade;
        }
        public override void Bonificação()
        {
            double Sal = 5000;
            Salario = Salario + Sal;
            Console.WriteLine($"O salário de supervisor do colaborador(a) {Nome} + bonificação é {Salario}.");
        }
    }
}