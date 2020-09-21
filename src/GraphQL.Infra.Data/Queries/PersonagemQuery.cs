using GraphQL.Types;
using GraphQL.Infra.Data.Types;
using GraphQL.Infra.Data.Interfaces;

namespace GraphQL.Infra.Data.Queries
{
    public class PersonagemQuery : ObjectGraphType
    {
        private readonly IPersonagemRepository _repository;

        public PersonagemQuery(IPersonagemRepository repository)
        {
            _repository = repository;

            Field<ListGraphType<PersonagemType>>("personagens",
                resolve: context =>
                {
                    return _repository.Obter();
                }
            );

            Field<PersonagemType>("personagem",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> 
                    { 
                        Name = "Id", 
                        Description = "Id do personagem" 
                    }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return _repository.Obter(id);
                }
            );
        }
    }
}