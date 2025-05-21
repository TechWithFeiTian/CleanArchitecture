using AutoMapper;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Common.Mappings
{
    /// <summary>
    /// 应用层包装类，聚合仓储、服务、AutoMapper
    /// </summary>
    public class Wrapper
    {
        public IRepositoryWrapper Repository { get; }
        public IServiceWrapper Service { get; }
        public IMapper Mapper { get; }

        public Wrapper(IRepositoryWrapper repository, IServiceWrapper service, IMapper mapper)
        {
            Repository = repository;
            Service = service;
            Mapper = mapper;
        }
    }

    public interface IRepositoryFactory
    {
        IRepository<T> GetRepository<T>() where T : class;
    }

    public interface IServiceFactory
    {
        T GetService<T>() where T : class;
    }
}