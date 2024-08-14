namespace DigitalPoetry.LibraryManager.Service.Infra.IoC.DependencyInjection
{
    using DigitalPoetry.LibraryManager.Service.Infra.Data.Interfaces.UnitOfWork;
    using DigitalPoetry.LibraryManager.Service.Infra.Data.UnitOfWork;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>Dependency Injection</summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IGenericRepository, GenericRepository>();
            return services;
        }
    }
}
