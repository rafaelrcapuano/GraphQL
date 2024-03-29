# GraphQL

> Exemplo de uma API baseada em GraphQL, utilizando C# e .NET Core 3.1.

## O que é?

- Contém a estrutura básica de uma API em GraphQL.

- Como exemplo, permite consultar os dados da entidade **PersonagemModel**, que são baseados na série **Os Cavaleiros do Zodíaco**, de Masami Kurumada.

- Possui a seguinte estrutura:

    **GraphQL.Api** => Responsável por configurar e disponibilizar a API e o **GraphQL Playground**.

    **GraphQL.Infra.CrossCutting** => Aqui acontece a configuração da injeção de dependência. Camada intermediária entre API e Infra.Data.

    **GraphQL.Infra.Data** => Contém a estrutura do GraphQL (schema, query e types), além da classe **PersonagemRepository**, que dá acesso aos dados.
	
	**GraphQL.Models** => Possui o modelo de dados deste exemplo.

    Você poderá encontrar mais detalhes sobre o tema [neste](https://medium.com/@rafacapuano/falando-a-mesma-l%C3%ADngua-com-graphql-parte-1-22cb838d404c?source=friends_link&sk=48f05cac2ec164048f1184f5c772d0a8) artigo.

## Requisitos

- Precisamos da versão 3.1 ou superior do .NET Core. Você pode fazer o download [aqui](https://dotnet.microsoft.com/download/dotnet-core).

- Utilizando o terminal de sua preferência, confirme se a instalação foi concluída com sucesso:

    ![dotnet-version](attachments/dotnet-version.png)

## Como utilizar?

- Acesse o diretório *\src\GraphQL.Api*, pois é lá que se encontra o arquivo *GraphQL.Api.csproj*. Execute o comando para iniciar o projeto e subir a API localmente:

    ```
    dotnet run
    ```

    ![dotnet-run](attachments/dotnet-run.png)

- No seu navegador preferido, verifique se a página do **GraphQL Playground** está disponível através deste endereço: https://localhost:5001/ui/playground.

    ![graphlq-playground](attachments/graphql-playground.png)

- Pronto. Agora é só fazer os testes utilizando a sintaxe do GraphQL! Segue um exemplo:

    ```
    {
      personagens {
        id,
        nome,
        constelacao,
        idade,
        localDeNascimento
        localDeTreinamento
      }
    }
    ```

## Referências

[GraphQL.org](https://graphql.org/)

[GraphQL para .NET](https://github.com/graphql-dotnet/graphql-dotnet)