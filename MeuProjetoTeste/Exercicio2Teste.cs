using Xunit;
using Exercicio2.Models;
namespace MeuProjetoTeste
{
    public class TesteExercicio2
    {
        [Fact]
        [Trait("Atividade2","TodasAtividades2")]
        [Trait("Atividade2","ImpostoLivroEducativo")]
        public void TestarSeLivroEducativoCobraImpostos()
        {
            //arrange
            Livro livro = new Livro("Cidades Mortas",30,1,"Dener Batista Lopes","educativo",250);
            livro.CalculaImposto();
            //act
            var esperado = 30;
            //assert.
            Assert.Equal(esperado, livro.preco);
        }
        [Fact]
        [Trait("Atividade2","TodasAtividades2")]
        [Trait("Atividade2","ImpostoLivroPadrao")]
        public void TestarSeLivroDeTemaPadraoCobraImpostos()
        {
            //arrange
            Livro livro = new Livro("O Velho e o Mar",45,1,"Ernest Hemingway","Romance",233);
            livro.CalculaImposto();
            //act
            var esperado = 49.5; //O imposto cobrado de livros padrões é de 10% do valor total do livro.
            //assert.
            Assert.Equal(esperado, livro.preco);
        }

        [Fact]
        [Trait("Atividade2","TodasAtividades2")]
        [Trait("Atividade2","ImpostoVideoGameUsado")]
        public void TestarSeVideoGameCobraImpostosUsadosCorretamente()
        {
            //arrange
            VideoGame videogame = new VideoGame("ps4",1800,100,"Sony","Slim",false);
            videogame.CalculaImposto();
            //act
            var esperado = 2610; //O imposto cobrado de VideoGames Novos é de 45% do valor total do livro.
            //assert.
            Assert.Equal(esperado, videogame.preco);

        }

        [Fact]
        [Trait("Atividade2","TodasAtividades2")]
        [Trait("Atividade2","ImpostoVideoGameNovo")]
        public void TestarSeVideoGameCobraImpostosNovosCorretamente()
        {
            //arrange
            VideoGame videogame = new VideoGame("ps4",1000,7,"Sony","Slim",true);
            videogame.CalculaImposto();
            //act
            var esperado = 1250; //O imposto cobrado de VideoGames Usados é de 25% do valor total do livro.
            //assert.
            Assert.Equal(esperado, videogame.preco);
        }

        //NAO FIZ O TESTE DA CLASSE 'LOJA' DO METODO "CalculaImpostos" Pois seria inviável realocar toda
        //a estrutura de listas de videos games e livros nesse teste. Portando é possivel confirmar o valor
        //total do valor contido na loja em: MENU.Atividade2/dotnet run.
    }
}