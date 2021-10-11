## Introdução

Nesse projeto, vamos aprende a como implementar de forma simples e fácil, o pattern Factory "fabrica" no .NET com C#.

## Pré-requisitos

Para poder acompanhar os exemplos desse artigo, os pré-requisitos são:

. SDK .NET
. Qualquer sistema operacional (Linux, Windows ou Mac)
. Qualquer IDE que dê suporte ao .NET (C#)


## O que é o Factory ?

Factory é um pattern super simples e muito utilizado, principalmente quando queremos abstrair a criação de uma classe. Ele é basicamente um método "estático" que possui um comportamento de "fábrica" retornando uma nova instância de uma classe quando chamado.


## Iniciando o Projeto

Nome do projeto: **DemoSamplePatternFactory**

Objetivo: Um cadastro de alunos


Vou criar o projeto utilizando os comandos da CLI pelo terminal, sendo assim, escolha um diretório para salvar o seu projeto, e na linha de comando digite a seguinte instrução:


dotnet new console -o DemoSamplePatternFactory


Nenhuma descrição de foto disponível.

O comando acima cria um novo projeto de console, e o parâmetro -o cria um diretório com o novo do projeto.

Após o projeto criado, utilize o seguinte comando para abri-ló no vs code.

code .

## Estrutura


Inicialmente a nossa aplicação abre com essa estrutura base.


Nenhuma descrição de foto disponível.

Vamos criar três pastas para organizar melhor a nossa aplicação.

. Entities
. Interfaces
. Factory


O resultado deve ficar assim:


Nenhuma descrição de foto disponível.



## Estrutura - Interface


Vamos iniciar criando uma interface com apenas dois membros "propriedades", um Id do tipo Guid, e um Name do tipo string, ambos assinando apenas o Get, para serem de somente leitura.

Nenhuma descrição de foto disponível.


## Estrutura - Classe


Agora, vamos criar a nossa classe implementando a nossa interface.


Nenhuma descrição de foto disponível.


Nossa classe é bem simples, com duas propriedades e um construtor que inicia sempre atribuindo um novo Id e rebebendo um nome por parâmetro.


## Estrutura - Factory


E por último, implementamos o padrão de fábrica, veja com é simples. Como utilizamos interfaces, podemos passar ela como o tipo de retorno, com isso, podemos receber qualquer estrutura que assine a interface IStudent.


Nenhuma descrição de foto disponível.


Lembre-se que, se no construtor da classe concreta, tiver parâmetros de retorno, eles devem ser passados também como parâmetros no método da Factory.


## Consumindo a Factory


E por último, vamos utilizar a nossa fábrica na classe Program.


Nenhuma descrição de foto disponível.


Sem aplicar o padrão, a criação da nossa classe ficaria assim:


      Student studen = new Student("Ana");


Ficou mais simples certo? Sim, porém o problema com essa abordagem, está nos quesitos "abstração e acoplamento" com o uso da palavra new.


## Conclusão


Nesse artigo, você aprendeu como criar um projeto de console pela linha de comando, organizando o código em pastas, depois criando interfaces e implementando-as em uma classe, e por último, aplicando o pattern Factory para abstrair a criação de uma classe.


Com isso vou ficando por aqui,


Pegue o projeto no GitHub: [Reporitório GitHub](https://github.com/CarlosEX/DemoSamplePatternFactory)

Um grande abraço,


Carlos Antonio



> "No dia da prosperidade, goza do bem, mas, no dia da adversidade, considera; porque também Deus fez este em oposição àquele, para que o homem nada ache que tenha de vir depois dele."
>
> Eclesiastes 7:14
