using System;
namespace Exercicio7.Models
{
      public class Vendedor : Funcionario
      {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            this.Salario = salario;
            this.Nome = nome;
            this.Idade = idade;
        }
        public override void Bonificação()
        {
            double Sal = 3000;
            Salario = Salario + Sal;
            Console.WriteLine($"O salário de vendedor do colaborador(a) {Nome} + bonificação é {Salario}.");
        }
      }
}