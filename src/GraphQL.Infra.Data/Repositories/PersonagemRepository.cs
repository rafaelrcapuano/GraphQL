using GraphQL.Infra.Data.Interfaces;
using GraphQL.Models;
using System.Collections.Generic;

namespace GraphQL.Infra.Data.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        private readonly ISession _session;

        public PersonagemRepository(ISession session)
        {
            _session = session;
        }

        public IList<PersonagemModel> Obter()
        {
            return _session.Obter();
        }

        public PersonagemModel Obter(int id)
        {
            return _session.Obter(id);
        }
    }
}