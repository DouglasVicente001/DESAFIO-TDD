using static System.Console;
namespace Menu.ExercicioDojoPuzzle
{
    public class TelaAtividadeDojo
    {   
        public void telaAtividadeDojoCaixaEletronico()
        {
            while(true)
            {
                int nota200, nota100, nota50, nota20, nota10, nota5, nota2,nota1 = 0;
        
                WriteLine("\n--------------------------------------------------"+
                "\n---------------  CAIXA ELETRÔNICO  ---------------"+
                "\n--------------------------------------------------"+
                "\nInforme quantos reais deseja sacar: ");
                int pedidoCliente = int.Parse(ReadLine());

                if (pedidoCliente >= 200)
                {    
                    nota200 = pedidoCliente / 200;
                    pedidoCliente = pedidoCliente % 200;
                    WriteLine($"Foram sacadas {nota200} nota(s) de 200");
                }
                if (pedidoCliente >= 100)
                {    
                    nota100 = pedidoCliente / 100;
                    pedidoCliente = pedidoCliente % 100;
                    WriteLine($"Foram sacadas {nota100} nota(s) de 100");
                }
                if(pedidoCliente >=50)
                {   
                    nota50 =  pedidoCliente / 50;
                    pedidoCliente = pedidoCliente % 50;
                    WriteLine($"Foram sacadas {nota50} nota(s) de 50");
                }
                if(pedidoCliente >=20)
                {   
                    nota20 = pedidoCliente / 20;
                    pedidoCliente = pedidoCliente % 20;
                    WriteLine($"Foram sacadas {nota20} nota(s) de 20");
                }
                if (pedidoCliente >=10)
                {   
                    nota10 = pedidoCliente / 10;
                    pedidoCliente = pedidoCliente % 10;
                    WriteLine($"Foram sacadas {nota10} nota(s) de 10");
                }
                if (pedidoCliente >=5)
                {   
                    nota5 = pedidoCliente / 5;
                    pedidoCliente = pedidoCliente % 5;
                    WriteLine($"Foram sacadas {nota5} nota(s) de 5");
                }
                if (pedidoCliente >=2)
                {   
                    nota2 = pedidoCliente / 2;
                    pedidoCliente = pedidoCliente % 2;
                    WriteLine($"Foram sacadas {nota2} nota(s) de 2");
                }
                if (pedidoCliente >=1)
                {   
                    nota1 = pedidoCliente / 1;
                    pedidoCliente = pedidoCliente % 1;
                    WriteLine($"Foram sacadas {nota1} nota(s) de 1");
                }

            WriteLine("Deseja sair do app Caixa Eletrônico? [S] / [N]"); 
            string saida = ReadLine();
            if (saida.Equals("s",System.StringComparison.InvariantCultureIgnoreCase))
            {
                WriteLine("Obrigado por utiizar o caixa! saindo...");
                break;
            }
            }
        }
    }
}