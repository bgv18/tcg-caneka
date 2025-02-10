using tcg_api.Interfaces;
using tcg_api.Services;

namespace tcg_api
{
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IPokemonIntegration, PokemonIntegration>();

            return services;
        }
    }
}
