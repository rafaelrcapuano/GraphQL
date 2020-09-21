using Autofac;
using GraphQL.Infra.Data;
using GraphQL.Infra.Data.Interfaces;
using GraphQL.Infra.Data.Queries;
using GraphQL.Infra.Data.Repositories;
using GraphQL.Infra.Data.Repositories.Mock;
using GraphQL.Infra.Data.Types;
using GraphQL.SystemTextJson;
using GraphQL.Types;

namespace GraphQL.Infra.CrossCutting
{
    public class InfraModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SessionMock>().As<ISession>().InstancePerLifetimeScope();
            builder.RegisterType<PersonagemRepository>().As<IPersonagemRepository>().InstancePerLifetimeScope();

            builder.RegisterType<PersonagemSchema>().As<ISchema>().InstancePerLifetimeScope();
            builder.RegisterType<DocumentWriter>().As<IDocumentWriter>().InstancePerLifetimeScope();
            builder.RegisterType<PersonagemQuery>().InstancePerLifetimeScope();
            builder.RegisterType<PersonagemType>().InstancePerLifetimeScope();
        }
    }
}