{Ferramentas}
Para o aplicativo entrar em execução: caminhe até a pasta 'menu' pelo terminal e digite: dotnet run

Para executar os testes Xunit, permeça no local principal "antes do menu", e digite: dotnet test -v n

{Instruções do Menu Principal}

Pressione [1] PARA ACESSAR EXERCICIO 1!

Pressione [2] PARA ACESSAR EXERCICIO 2!

Pressione [3] PARA ACESSAR EXERCICIO 3!

Pressione [4,5,6] PARA ACESSAR EXERCICIO  4-6'qualquer dos 3 dígitos!

Pressione [7] PARA ACESSAR EXERCICIO 7!

Pressione [8] PARA ACESSAR EXERCICIO DOJOPUZZLES!

Pressione [0] OU QUALQUER OUTRO DÍGITO FORA ESSES ACIMA PARA [SAIR]!

Pressione [S] Se deseja sair de toda aplicação ou [N] para continuar.


{Instruições Testes Unitários - Xunit}


dotnet test -v n   //Para acessar todos testes.

//Para executar um teste de uma aplicação determinada utilize os comandos abaixo:

dotnet test -v n --filter 
Atividade1=TodasAtividades1

dotnet test -v n --filter Atividade2=TodasAtividades2

dotnet test -v n --filter 
Atividade3=TodasAtividade3

dotnet test -v n --filter 
Atividade7=TodasAtividade7

dotnet test -v n --filter 
AtividadeDojo=TodasAtividadesDojo

Clécio se deseja testar um teste de método específico, todos os testes contém um (Trait)diferente, para que haja possibilidade de acessar um teste específico. Observe o trait do metodo desejado e aplique-o ao filtro.