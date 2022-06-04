using Menu.ExercicioDojoPuzzle;
using Xunit;
namespace MeuProjetoTeste
{
    public class TesteExercicioDojo
    {
        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste200Reais")]
        public void TesteDoCalculoDe200()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 50;
            var nota200 = 200;
            var pedidoCliente = 250;
            //act
            var resultado = nota200 = pedidoCliente % 200;
            //assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste100Reais")]
        public void TesteDoCalculoDe100()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 20;
            var nota100 = 100;
            var pedidoCliente = 120;
            //act
            var resultado = nota100 = pedidoCliente % 100;
            //assert
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste50Reais")]
        public void TesteDoCalculoDe50()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 15;
            var nota50 = 50;
            var pedidoCliente = 65;
            //act
            var resultado = nota50 = pedidoCliente % 50;
            //assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste20Reais")]
        public void TesteDoCalculoDe20()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 10;
            var nota20 = 20;
            var pedidoCliente = 30;
            //act
            var resultado = nota20 = pedidoCliente % 20;
            //assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste10Reais")]
        public void TesteDoCalculoDe10()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 5;
            var nota10 = 10;
            var pedidoCliente = 15;
            //act
            var resultado = nota10 = pedidoCliente % 10;
            //assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste5Reais")]
        public void TesteDoCalculoDe5()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 2;
            var nota5 = 5;
            var pedidoCliente = 7;
            //act
            var resultado = nota5 = pedidoCliente % 5;
            //assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste2Reais")]
        public void TesteDoCalculoDe2()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 1;
            var nota2 = 2;
            var pedidoCliente = 3;
            //act
            var resultado = nota2 = pedidoCliente % 2;
            //assert
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        [Trait("AtividadeDojo", "TodasAtividadesDojo")]
        [Trait("AtividadeDojo","Teste1Real")]
        public void TesteDoCalculoDe1()
        {   
            //arrange
            TelaAtividadeDojo dojo = new TelaAtividadeDojo();
            var esperado = 0;
            var nota1 = 1;
            var pedidoCliente = 1;
            //act
            var resultado = nota1 = pedidoCliente % 1;
            //assert
            Assert.Equal(esperado, resultado);
        }

    }
}