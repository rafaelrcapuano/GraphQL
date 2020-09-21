using GraphQL.Infra.Data.Interfaces;
using GraphQL.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Infra.Data.Repositories.Mock
{
    public class SessionMock : ISession
    {
        private readonly IList<PersonagemModel> _personagens;

        public SessionMock()
        {
            _personagens = new List<PersonagemModel>();

            var mu = new PersonagemModel
            {
                Id = 1,
                Nome = "Mu",
                Constelacao = "Áries",
                Idade = 20,
                LocalDeNascimento = "Tibete",
                LocalDeTreinamento = "Jamiel",
            };
            _personagens.Add(mu);

            var aldebaran = new PersonagemModel
            {
                Id = 2,
                Nome = "Aldebaran",
                Constelacao = "Touro",
                Idade = 20,
                LocalDeNascimento = "Brasil",
                LocalDeTreinamento = "Brasil"
            };
            _personagens.Add(aldebaran);

            var saga = new PersonagemModel
            {
                Id = 3,
                Nome = "Saga",
                Constelacao = "Gêmeos",
                Idade = 28,
                LocalDeNascimento = "Grécia",
                LocalDeTreinamento = "Grécia (Santuário)"
            };
            _personagens.Add(saga);

            var mascaraDaMorte = new PersonagemModel
            {
                Id = 4,
                Nome = "Máscara da Morte",
                Constelacao = "Câncer",
                Idade = 23,
                LocalDeNascimento = "Itália",
                LocalDeTreinamento = "Ilha da Sicília"
            };
            _personagens.Add(mascaraDaMorte);

            var aiolia = new PersonagemModel
            {
                Id = 5,
                Nome = "Aiolia",
                Constelacao = "Leão",
                Idade = 20,
                LocalDeNascimento = "Grécia",
                LocalDeTreinamento = "Grécia (Santuário)"
            };
            _personagens.Add(aiolia);

            var shaka = new PersonagemModel
            {
                Id = 6,
                Nome = "Shaka",
                Constelacao = "Virgem",
                Idade = 20,
                LocalDeNascimento = "Índia",
                LocalDeTreinamento = "Índia (Ganges)"
            };
            _personagens.Add(shaka);

            var dohko = new PersonagemModel
            {
                Id = 7,
                Nome = "Dohko (Mestre Ancião)",
                Constelacao = "Libra",
                Idade = 261,
                LocalDeNascimento = "China",
                LocalDeTreinamento = "China (Cinco Picos Antigos de Rozan)"
            };
            _personagens.Add(dohko);

            var milo = new PersonagemModel
            {
                Id = 8,
                Nome = "Milo",
                Constelacao = "Escorpião",
                Idade = 20,
                LocalDeNascimento = "Grécia",
                LocalDeTreinamento = "Grécia (Ilha de Milos)"
            };
            _personagens.Add(milo);

            var aiolos = new PersonagemModel
            {
                Id = 9,
                Nome = "Aiolos",
                Constelacao = "Sagitário",
                Idade = 14,
                LocalDeNascimento = "Grécia",
                LocalDeTreinamento = "Grécia (Santuário)"
            };
            _personagens.Add(aiolos);

            var shura = new PersonagemModel
            {
                Id = 10,
                Nome = "Shura",
                Constelacao = "Capricórnio",
                Idade = 23,
                LocalDeNascimento = "Espanha",
                LocalDeTreinamento = "Espanha (Montes Pirineus)"
            };
            _personagens.Add(shura);

            var camus = new PersonagemModel
            {
                Id = 11,
                Nome = "Camus",
                Constelacao = "Aquário",
                Idade = 20,
                LocalDeNascimento = "França",
                LocalDeTreinamento = "Sibéria"
            };
            _personagens.Add(camus);

            var afrodite = new PersonagemModel
            {
                Id = 12,
                Nome = "Afrodite",
                Constelacao = "Peixes",
                Idade = 22,
                LocalDeNascimento = "Suécia",
                LocalDeTreinamento = "Groenlândia"
            };
            _personagens.Add(afrodite);
        }

        public IList<PersonagemModel> Obter()
        {
            return _personagens;
        }

        public PersonagemModel Obter(int id)
        {
            return _personagens.SingleOrDefault(x => x.Id == id);
        }
    }
}
