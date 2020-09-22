# GraphQL

> Exemplo de uma API baseada em GraphQL utilizando C# e .NET Core 3.1.

# O que é?

- Contém a estrutura básica de uma API baseada em GraphQL;

- Como exemplo, permite consulta ao dados da entidade **Personagem**;

- Os dados dos personagens são baseados na série **Os Cavaleiros do Zodíaco**;

- Possui a seguinte estrutura:

    **GraphQL.Api** => Responsável por configurar e disponibilizar a API e o **GraphQL Playground**;

    **GraphQL.Infra.CrossCutting** => Responsável pela configuração da injeção de dependência. Camada intermediária entre API e Infra.Data;

    **GraphQL.Infra.Data** => Contém a estrutura do GraphQL (schema, query e types), além da classe **PersonagemRepository** que dá acesso aos dados;
	
	**GraphQL.Models** => Contém o modelo de dados de exemplo: a entidade **Personagem**.
  

# Requisitos

- É necessário ter instalada a versão 3.1 ou superior do .NET Core. Para isso, faça o download através do link: https://dotnet.microsoft.com/download/dotnet-core

- Confirme se a instalaçao foi concluída com sucesso através do terminal de sua preferência:

![image.png](attachments/dotnet-version.png)

# Como utilizar?

- No repositório local, acesse o diretório *".../GraphQL/src/GraphQL.Api*", pois é lá que se encontra o arquivo *GraphQL.Api.csproj*. Execute o seguinte comando para iniciar o projeto e subir a API localmente:

```
dotnet run
```

![image.png](attachments/dotnet-run.png)

- No navegador de sua preferência, confirme se a página do **GraphQL Playground** está disponível através do endereço: https://localhost:5001/ui/playground

![image.png](attachments/graphql-playground.png)

- Pronto. Agora é só fazer os testes utilizando sintaxe do GraphQL!