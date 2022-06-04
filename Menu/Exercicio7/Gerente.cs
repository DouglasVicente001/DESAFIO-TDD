using System;
namespace Exercicio7.Models
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            this.Salario = salario;
            this.Nome = nome;
            this.Idade = idade;
        }
        public override void Bonificação()
        {
            double Sal = 10000;
            this.Salario = Salario + Sal;
            Console.WriteLine($"O salário de gerente do colaborador(a) {Nome} + bonificação é {Salario}.");
        }

    }
}