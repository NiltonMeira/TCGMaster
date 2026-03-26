using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCGMaster.Application.Interfaces;
using TCGMaster.Application.Services;
using TCGMaster.Infrastructure.Data;
using TCGMaster.Infrastructure.Repositories;

namespace TCGMaster.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IDeckRepository, DeckRepository>();
        services.AddScoped<DeckService>();

        return services;
    }
}