using GraphQL.Models;
using GraphQL.Types;

namespace GraphQL.Infra.Data.Types
{
    public class PersonagemType : ObjectGraphType<PersonagemModel>
    {
        public PersonagemType()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Nome);
            Field(x => x.Constelacao)
                .Description("Uma das doze constelações que representam os signos do zodíaco.");
            Field(x => x.Idade);
            Field(x => x.LocalDeNascimento);
            Field(x => x.LocalDeTreinamento);
        }
    }
}