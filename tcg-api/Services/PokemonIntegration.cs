using Microsoft.Extensions.Options;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards;
using tcg_api.Interfaces;

namespace tcg_api.Services
{
    public class PokemonIntegration : IPokemonIntegration
    {
        private readonly ConfigurationParameters _config;
        private readonly PokemonApiClient _pokeClient;
        public PokemonIntegration(IOptions<ConfigurationParameters> options)
        {
            _config = options.Value;
            _pokeClient = initializeClient();
        }

        public Task<List<PokemonCard>> GetPokemonCardsByFilterPagination()
        {
            throw new NotImplementedException();
        }

        public async Task<List<PokemonCard>> GetPokemonCardsByPagination(int take, int skip)
        {
            var apiResourceList = await _pokeClient.GetApiResourceAsync<PokemonCard>(take, skip);
            var cards = apiResourceList.Results;

            return cards;
        }

        private PokemonApiClient initializeClient()
        {
            return new PokemonApiClient(_config.API_KEY);
        }
    }
}
