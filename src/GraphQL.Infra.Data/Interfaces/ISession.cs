using GraphQL.Models;
using System.Collections.Generic;

namespace GraphQL.Infra.Data.Interfaces
{
    public interface ISession
    {
        IList<PersonagemModel> Obter();

        PersonagemModel Obter(int id);
    }
}