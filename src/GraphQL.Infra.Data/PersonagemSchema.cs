using GraphQL.Infra.Data.Queries;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace GraphQL.Infra.Data
{
    public class PersonagemSchema : Schema
    {
        public PersonagemSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<PersonagemQuery>();            
        }
    }
}