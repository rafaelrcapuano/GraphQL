using GraphQL.Models;
using System.Collections.Generic;

namespace GraphQL.Infra.Data.Interfaces
{
    public interface IPersonagemRepository
    {
        IList<PersonagemModel> Obter();

        PersonagemModel Obter(int id);
    }
}