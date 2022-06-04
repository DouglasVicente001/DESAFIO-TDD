using System;
using Exercicio7.Models;
using Xunit;

namespace MeuProjetoTeste
{   
    public class TesteExercicio7
    {
        [Fact]
        [Trait("Atividade7","TodasAtividades7")]
        [Trait("Atividade7","TesteSupervisor")]
        public void TestarBonificaçãoTotalDoSupervisor()
        {
            //arrange
            Supervisor supervisor = new Supervisor ("Junior",33,2000);
            supervisor.Bonificação();
            //act
            var resultado = supervisor.Salario;
            var esperado = 7000;
            //assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Atividade7","TodasAtividades7")]
        [Trait("Atividade7","TesteVendedor")]
        public void TestarBonificaçãoTotalDoVendedor()
        {
            //arrange
            Vendedor vendedor = new Vendedor("Jao",25,1500);
            vendedor.Bonificação();
            //act
            var resultado = vendedor.Salario;
            var esperado = 4500;
            //assert
            Assert.Equal(esperado, resultado);
        }
        
        [Fact]
        [Trait("Atividade7","TodasAtividades7")]
        [Trait("Atividade7","TesteGerente")]
        public void TestarBonificaçãoTotalDoGerente()
        {
            //arrange
            Gerente gerente = new Gerente ("Pedro",50,7000);
            gerente.Bonificação();
            //act
            var resultado = gerente.Salario;
            var esperado = 17000;
            //assert
            Assert.Equal(esperado, resultado);
        }  

        [Theory(DisplayName = "TeoriasBonificações")]
        [Trait("Atividade7","TodasAtividades7")]
        [Trait("Atividade7","TesteTodasBonificacoes")]
        [InlineData(1500,3000,4500)]
        [InlineData(2000,5000,7000)]
        [InlineData(7000,10000,17000)]

        public void TesteTodasBonificaçõesDeTodosFunciorarios(int salario, int bonificacao, int esperado)
        {
            //arrange
            //act
            var resultado = salario + bonificacao;
            //assert
            Assert.Equal(esperado,resultado);
        }
    }
}
