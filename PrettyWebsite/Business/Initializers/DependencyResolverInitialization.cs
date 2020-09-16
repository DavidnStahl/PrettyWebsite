
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using PrettyWebsite.Repositories;
using PrettyWebsite.Repositories.Interfaces;
using PrettyWebsite.Services;
using System.Web.Mvc;

namespace PrettyWebsite.Business.Initializers
{
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.ConfigurationComplete += (o, e) =>
            {
                context.Services.AddTransient<IRssFeedService, RssFeedService>();
                context.Services.AddTransient<IDataStoreRepository, DataStoreRepository>();
                context.Services.AddTransient<IMovieRepository, MovieRepository>();
            };
        }
    }
}