using CleanArchitecture.Application.Common.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.Services
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T GetService<T>() where T : class
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}