using CleanArchitecture.Domain.Common;
using CleanArchitecture.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Application.Common.Mappings;

namespace CleanArchitecture.Infrastructure.Data
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public RepositoryFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return _serviceProvider.GetRequiredService<IRepository<T>>();
        }
    }
}