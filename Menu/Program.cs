using Exercicio7;
using Exercicio4;
using Exercicio3;
using Exercicio2;
using Exercicio1;
using static System.Console;
using Exercicio7.Models;
using Menu.ExercicioDojoPuzzle;

namespace Menu
{
    class Program
    {
        public static void Main(string[] args)
        {   
            while(true)
            {    
                string Mensagem = "\nTABELA DE ATIVIDADES DO CLECIO!"+
                "\n=============================================================="+
                "\n--------------------------  MENU  ----------------------------"+
                "\n=============================================================="+
                "\nPara acessar a Atividade 1 'Criando Automóveis', Pressione [1]"+
                "\nPara acessar a Atividade 2 'Loja Americanas', Pressione [2]"+
                "\nPara acessar a Atividade 3 'Jogo de RPG MonsterForce', Pressione [3]"+
                "\nPara acessar a Atividade 4-6 'App lista de nomes e exclusões', Pressione [4]"+
                "\nPara acessar a Atividade 7 'app Funcionario + bonificação = felicidade', Pressione [7]"+
                "\nPara acessar a Atividade DojoPuzzles 'app Exceeds Puzzles', Pressione [8]"+
                "\nPara sair da aplicação Pressione [0] ou qualquer outro numero fora os listados acima!";
                WriteLine(Mensagem);
                int OpcaoEscolhaUsuario = int.Parse(ReadLine());
                if(OpcaoEscolhaUsuario == 0 && OpcaoEscolhaUsuario > 7)
                {
                    break;
                }
                switch(OpcaoEscolhaUsuario)
                {  
                case 1:
                TelaAtividade1 tela1 = new TelaAtividade1();
                tela1.telaAtividade();
                break;

                case 2:
                TelaAtividade2 tela2 = new TelaAtividade2();
                tela2.telaAtividade2();
                break;

                case 3:
                TelaAtividade3 tela3 = new TelaAtividade3();
                tela3.telaAtividade3();
                break;

                case 4:
                case 5:
                case 6:
                TelaAtividade4 tela4 = new TelaAtividade4();
                tela4.TelaAtividade4_6();
                break;

                case 7:
                TelaAtividade7 tela7= new TelaAtividade7();
                tela7.telaAtividade7();
                break;

                case 8:
                TelaAtividadeDojo telaDojo = new TelaAtividadeDojo();
                telaDojo.telaAtividadeDojoCaixaEletronico();
                break;
                }
                
                WriteLine("Deseja sair do Menu Principal e fechar todas aplicações?  [S] / [N]");
                string OpcaoUsuario = ReadLine();
                
                if(OpcaoUsuario.Equals("s",System.StringComparison.InvariantCultureIgnoreCase))
                {
                    WriteLine("Clécio, obrigado por utilizar o app Atividades...");
                    break;
                }
            

            }
        }
    }
}
