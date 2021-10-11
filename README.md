## Introdução

Nesse projeto, vamos aprende a como implementar de forma simples e fácil, o pattern Factory "fabrica" no .NET com C#.

## Pré-requisitos

Para poder acompanhar os exemplos desse artigo, os pré-requisitos são:

- SDK .NET
- Qualquer sistema operacional (Linux, Windows ou Mac)
- Qualquer IDE que dê suporte ao .NET (C#)


## O que é o Factory ?

Factory é um pattern super simples e muito utilizado, principalmente quando queremos abstrair a criação de uma classe. Ele é basicamente um método "estático" que possui um comportamento de "fábrica" retornando uma nova instância de uma classe quando chamado.


## Iniciando o Projeto

Nome do projeto: **DemoSamplePatternFactory**

Objetivo: Um cadastro de alunos


Vou criar o projeto utilizando os comandos da CLI pelo terminal, sendo assim, escolha um diretório para salvar o seu projeto, e na linha de comando digite a seguinte instrução:


      dotnet new console -o DemoSamplePatternFactory
      
![Captura de tela de 2021-10-10 21-02-24](https://user-images.githubusercontent.com/33513870/136775408-000366e9-131c-4e6a-845a-cd6dd7537afc.png)


O comando acima cria um novo projeto de console, e o parâmetro -o cria um diretório com o novo do projeto.

Após o projeto criado, utilize o seguinte comando para abri-ló no vs code.

      code .

## Estrutura

Inicialmente a nossa aplicação abre com essa estrutura base.

![Captura de tela de 2021-10-10 21-03-46](https://user-images.githubusercontent.com/33513870/136775698-5bf2cdcf-4565-420e-a091-86fb43143376.png)

Vamos criar três pastas para organizar melhor a nossa aplicação.

- Entities
- Interfaces
- Factory

O resultado deve ficar assim:

![Captura de tela de 2021-10-10 21-15-24](https://user-images.githubusercontent.com/33513870/136775756-7a4af34a-2853-485a-b097-5af68bd375e3.png)

## Estrutura - Interface

Vamos iniciar criando uma interface com apenas dois membros "propriedades", um Id do tipo Guid, e um Name do tipo string, ambos assinando apenas o Get, para serem de somente leitura.

![Captura de tela de 2021-10-11 01-32-01](https://user-images.githubusercontent.com/33513870/136775844-3ac9727a-7d13-450b-8be4-90ce26e44253.png)

## Estrutura - Classe

Agora, vamos criar a nossa classe implementando a nossa interface.

![Captura de tela de 2021-10-11 01-31-23](https://user-images.githubusercontent.com/33513870/136775911-fc042e84-872b-4f1a-8920-6b411cda6fde.png)

Nossa classe é bem simples, com duas propriedades e um construtor que inicia sempre atribuindo um novo Id e rebebendo um nome por parâmetro.

## Estrutura - Factory

E por último, implementamos o padrão de fábrica, veja com é simples. Como utilizamos interfaces, podemos passar ela como o tipo de retorno, com isso, podemos receber qualquer estrutura que assine a interface IStudent.

![Captura de tela de 2021-10-11 01-32-26](https://user-images.githubusercontent.com/33513870/136775967-44ef0e54-33f9-45c8-83d2-08c44a0b72af.png)

Lembre-se que, se no construtor da classe concreta, tiver parâmetros de retorno, eles devem ser passados também como parâmetros no método da Factory.

## Consumindo a Factory

E por último, vamos utilizar a nossa fábrica na classe Program.

![Captura de tela de 2021-10-10 21-16-04](https://user-images.githubusercontent.com/33513870/136776017-1809dcef-ebd7-46bc-922a-f3d4c023f91a.png)

Sem aplicar o padrão, a criação da nossa classe ficaria assim:

      Student studen = new Student("Ana");

Ficou mais simples certo? Sim, porém o problema com essa abordagem, está nos quesitos "abstração e acoplamento" com o uso da palavra new.

## Conclusão

Nesse artigo, você aprendeu como criar um projeto de console pela linha de comando, organizando o código em pastas, depois criando interfaces e implementando-as em uma classe, e por último, aplicando o pattern Factory para abstrair a criação de uma classe.

## Tecnologias

- Linux (Fedora)
- .NET 5 (C#)
- Visual Studio Code
- CLI .NET

Com isso vou ficando por aqui,

Pegue o projeto no GitHub: [Reporitório GitHub](https://github.com/CarlosEX/DemoSamplePatternFactory)

Um grande abraço,


Carlos Antonio

> "No dia da prosperidade, goza do bem, mas, no dia da adversidade, considera; porque também Deus fez este em oposição àquele, para que o homem nada ache que tenha de vir depois dele."
>
> Eclesiastes 7:14
