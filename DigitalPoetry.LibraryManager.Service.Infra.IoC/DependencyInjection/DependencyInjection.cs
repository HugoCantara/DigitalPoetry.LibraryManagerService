namespace DigitalPoetry.LibraryManager.Service.Infra.IoC.DependencyInjection
{
    using DigitalPoetry.LibraryManager.Service.Infra.Data.Context;
    using DigitalPoetry.LibraryManager.Service.Infra.Data.Interfaces.UnitOfWork;
    using DigitalPoetry.LibraryManager.Service.Infra.Data.UnitOfWork;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>Dependency Injection</summary>
    public static class DependencyInjection
    {
        /// <summary>Database Connection Description</summary>
        private const string CONNECTION_DESCRIPTION = "DefaultConnection";

        /// <summary>Add Configuration Manager</summary>
        /// <param name="services">Service Collection</param>
        /// <param name="configuration">Configuration Manager</param>
        /// <returns>Service Collection</returns>
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            return services;
        }

        /// <summary>Add Configured Context</summary>
        /// <param name="services">Service Collection</param>
        /// <param name="configuration">Configuration Manager</param>
        /// <returns>Service Collection</returns>
        public static IServiceCollection AddConfiguredContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(CONNECTION_DESCRIPTION), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            return services;
        }

        /// <summary>Add Repositories</summary>
        /// <param name="services">Service Collection</param>
        /// <returns>Service Collection</returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IGenericRepository, GenericRepository>();
            return services;
        }
    }
}