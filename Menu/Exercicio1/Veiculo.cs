using static System.Console;
namespace Exercicio1.Models
{
    public class Veiculo
    {   
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int Velocidade { get; set; }
        public int litrosCombustivel { get; set; }
        public float Km { get; set; }
        public bool isLigado { get; set; }
        
            public Veiculo(string marca, string modelo, string placa, string cor, int velocidade, int litrosCombustivel, float km, bool isligado)
            {
                  Marca = marca;
                  Modelo = modelo;
                  Placa = placa;
                  Cor = cor;
                  Velocidade = velocidade;
                  this.litrosCombustivel = litrosCombustivel;
                  Km = km;
                  isligado = isLigado;
            }
            public void Acelerar()
            {
                Velocidade = Velocidade + 20;
                WriteLine($"A velocidade atual é: {Velocidade}");
            }
            public void Abastecer(int combustivel)
            {
                litrosCombustivel = litrosCombustivel + combustivel;
                if (litrosCombustivel <= 60)
                {
                    WriteLine($"O tanque está com {combustivel} litros de gasolina.");
                } 
                else if(litrosCombustivel > 60)
                {   
                    litrosCombustivel = 60;
                    WriteLine($"O tanque foi completado! e está com {combustivel} litros de gasolina.");
                }
            }
            public void Frear()
            {
                Velocidade = Velocidade -20;
                if (Velocidade > 0)
                {   
                    WriteLine($"Após usar o freio você reduziu 20km/h e está em uma velocidade de {Velocidade} km/h.");
                } 
                else
                {   
                    Velocidade = 0;
                    WriteLine("Não foi póssivel frear o veículo pois está parado! ");
                }
            }
            public void Pintar(string cor)
            {
                this.Cor = cor;
                WriteLine($"A cor atual do veiculo é {cor}");
            }
            public void Ligar()
            { 
                if (isLigado.Equals(false))
                {
                   isLigado = true;
                   WriteLine("Voce ligou o veículo");
                }
            }
            public void Desligar()
            {
                if (isLigado.Equals(true))
                {   
                    isLigado = false;
                    WriteLine("Você desligou o veículo");
                }
            }
    }
}