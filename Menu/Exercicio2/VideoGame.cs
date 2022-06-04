using static System.Console;
namespace Exercicio2.Models
{
    public class VideoGame : Produto, Iimposto
    {
      public VideoGame(string nome, double preco, int qtd,string marca,string modelo,bool isusado) : base(nome, preco, qtd)
    {
      this.marca = marca;
      this.modelo = modelo;
      this.isUsado = isusado;
      this.preco = preco;
    }

    public string marca { get; set; }
    public string modelo { get; set; }
    public bool isUsado { get; set; }
    public VideoGame()
    {

    }
    public void CalculaImposto()
    {
      if (isUsado == true)
      {
        isUsado = true;
        double imposto = (preco * 25)/100;
        preco = preco + imposto;

        WriteLine($"O produto é de característica 'usado'. Desta forma adquiriu 25% de impostos sendo R${imposto} Reais de imposto, portando valor total do produto é: R${preco} Reais.");
      }
      else if (isUsado == false)
      {
        isUsado = false;
        double imposto = (preco * 45)/100;
        preco = preco + imposto;

        WriteLine($"O produto é de característica 'novo'. Desta forma adquiriu 45% de impostos sendo R${imposto} Reais de imposto, portando valor total do produto é: R${preco} Reais.");
      }
    }
  }
}