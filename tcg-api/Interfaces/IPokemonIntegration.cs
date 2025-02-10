using PokemonTcgSdk.Standard.Infrastructure.HttpClients;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards;

namespace tcg_api.Interfaces
{
    public interface IPokemonIntegration
    {
        public Task<List<PokemonCard>> GetPokemonCardsByPagination(int take, int skip);
        public Task<List<PokemonCard>> GetPokemonCardsByFilterPagination();
    }
}
