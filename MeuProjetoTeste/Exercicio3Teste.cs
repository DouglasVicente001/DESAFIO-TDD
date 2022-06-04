using Xunit;
using Exercicio3.Models;
using Xunit.Abstractions;

namespace MeuProjetoTeste
{   
    public class TesteExercicio3
    {   
        ITestOutputHelper _output;
        public TesteExercicio3(ITestOutputHelper output)
        {
            _output = output;
        }
        
        [Theory(DisplayName = "TeoriaDeNivelamentoDeLevelUp")]
        [Trait("Atividade3","TodasAtividades3")]
        [Trait("Atividade3","TesteLevelUpNivelamento")]
        [InlineData("Mago: ",1800,2600,400,165,4965)]  //Mago
        [InlineData("Guerreiro: ",2300,800,170,420,3690)]  //Guerreiro
        [InlineData("Assasino:",2750,2000,378,388,5516)]  //Assasino
        [InlineData("Arqueiro:",1900,1950,378,388,4616)]  //Arqueiro
        [InlineData("DEMOM HUNTER BOSS:",20300,4800,1400,1350,27850)]  //bossFinal


        public void TestarLevelUpDeTodasAsClassesParaNivelamento(string TipoPersonagem,int Vida,int Mana,int Inteligencia, int Forca,int Esperado)
        {   //arrange
            Mago mago = new Mago("Mago Negro",1500,2300,7000,300,65,45);
            Guerreiro guerreiro = new Guerreiro ("guerreiro das sombras",2000,500,6000,70,320,43);
            Assasino assasino = new Assasino ("Ninja Hashirama",2450,1700,10000,110,288,55);
            Arqueiro arqueiro = new Arqueiro ("Archer Mistophin",1600,1650,8000,278,288,47);
            Boss bossFinal = new Boss ("DEMOM HUNTER BOSS",20000,4500,50000,1300,1250,99);
            //act
            var Resultado =  Vida + Mana + Inteligencia + Forca; //Levelup += Vida: +300 pontos Mana: +300 pontos. Int: +100. For: +100 pontos. 
            var personagem = TipoPersonagem;
            //assert 
            Assert.Equal(Esperado, Resultado);
        }

        [Fact]
        [Trait("Atividade3","TodasAtividades3")]
        [Trait("Atividade3","TesteAttack")]
        public void TesteDeAttackBrutoDosPersonagens()
        {
            //arrange
            Mago mago = new Mago("Mago Negro",1500,2300,7000,300,65,45);
            Guerreiro guerreiro = new Guerreiro ("guerreiro das sombras",2000,500,6000,70,320,43);
            Boss bossFinal = new Boss ("DEMOM HUNTER BOSS",20000,4500,50000,1300,1250,99);
            var DanoMagicoEsperado = 13500; //No app + 0/300 por adicional Random!
            var DanoFisicoEsperado = 13760; //No app + 0/300 por adicional Random!
            var DanoBossEsperado = 21658;   //No app + 0/300 por adicional Random!
            //act
            var resultadoDanoMagico = mago.Inteligencia * mago.Level;
            var resultadoDanoFisico = guerreiro.Forca * guerreiro.Level;
            var ResultadoDanoBoss = (bossFinal.Forca + bossFinal.Inteligencia * bossFinal.Level)/6;
            //assert
            Assert.Equal(DanoMagicoEsperado, resultadoDanoMagico);
            Assert.Equal(DanoFisicoEsperado, resultadoDanoFisico);
            Assert.Equal(DanoBossEsperado, ResultadoDanoBoss);
            _output.WriteLine($"TesteDeAttackBrutoDosPersonagens: Media dano magico = {DanoMagicoEsperado} Media Dano Fisico {DanoFisicoEsperado} Media Dano Boss {DanoBossEsperado}");
        }
        
    }
}