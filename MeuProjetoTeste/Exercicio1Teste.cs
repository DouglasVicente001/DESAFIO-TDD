using Xunit;
using Exercicio1.Models;
namespace MeuProjetoTeste
{   
    public class TesteExercicio1
    {
        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","AlterarCorVeiculo")]
        public void TesteDeAlterarCorDoVeiculo()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",45,50,42,true);
            var esperado = "preto";
            //act
            carro.Pintar("preto");
            //assert
            Assert.Equal(esperado, carro.Cor);
        }

        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","AceleracaoVeiculo")]
        public void TesteDeAceleracaoDoVeiculo()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",45,50,42,true);
            var esperado = 65;
            //act
            carro.Acelerar();
            //assert
            Assert.Equal(esperado, carro.Velocidade);
        }

        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","AbastecerVeiculo")]
        public void TesteDeAbastecimentoDoVeiculo()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",45,30,42,true);
            var esperado = 55;
            //act
            carro.Abastecer(25);
            //assert
            Assert.Equal(esperado, carro.litrosCombustivel);
        }

        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","TanqueCheioVeiculo")]
        public void TesteDeAbastecimentoDoVeiculoTanqueCheio()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",45,55,42,true);
            var esperado = 60;
            //act
            carro.Abastecer(100);
            //assert
            Assert.Equal(esperado, carro.litrosCombustivel);
        }

        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","FreioVeiculo")]
        public void TesteDeFreioDoVeiculo()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",45,55,42,true);
            var esperado = 25;
            //act
            carro.Frear();
            //assert
            Assert.Equal(esperado, carro.Velocidade);
        }

        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","FrearVeiculoParado")]
        public void TesteDeFrearVeiculoParado()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",0,55,42,true);
            var esperado = 0;
            //act
            carro.Frear();
            //assert
            Assert.Equal(esperado, carro.Velocidade);
        }

        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","LigarVeiculo")]
        public void TesteDeLigarVeiculo()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",0,55,42,false);
            var esperado = true;
            //act
            carro.Ligar();
            //assert
            Assert.Equal(esperado, carro.isLigado);
        }

        [Fact]
        [Trait("Atividade1","TodasAtividades1")]
        [Trait("Atividade1","DesligarVeiculo")]
        public void TesteDeDesligarVeiculo()
        {
            //arrange
            Veiculo carro = new Veiculo("Hyundai","ret","FDS-2369","branco",0,55,42,true);
            var esperado = false;
            //act
            carro.Desligar();
            //assert
            Assert.Equal(esperado, carro.isLigado);
        }
    }
}