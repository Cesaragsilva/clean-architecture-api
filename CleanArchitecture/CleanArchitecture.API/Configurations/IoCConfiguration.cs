using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infraestructure.Context;
using CleanArchitecture.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.API.Configurations
{
    public static class IoCConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<CleanArchitectureDbContext>(opt => opt.UseInMemoryDatabase("CleanArchitectureDb"));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<ICarServiceApplication, CarServiceApplication>();
            return services;
        }
    }
}
