﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tcg_api.Interfaces;

namespace tcg_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> PokemonCardListPagination(
            [FromServices] IPokemonIntegration pokemonIntegration, 
            int take, int skip)
        {
            var cards = await pokemonIntegration.GetPokemonCardsByPagination(take, skip);
            return Ok(cards);
        }

        [HttpGet]
        [Route("filter")]
        public async Task<IActionResult> PokemonCardListFilterPagination(
            [FromServices] IPokemonIntegration pokemonIntegration
            )
        {
            var cards = await pokemonIntegration.GetPokemonCardsByFilterPagination();
            return Ok(cards);
        }

        [HttpGet]
        [Route("namelist")]
        public async Task<IActionResult> PokemonCardListByName(
            [FromServices] IPokemonIntegration pokemonIntegration, string name, 
            int take, int skip)

        {
            var cards = await pokemonIntegration.GetPokemonCardsByName(name, take, skip);
         
            return cards.Count == 0 ? BadRequest() : Ok(cards);
        }
    }
}
