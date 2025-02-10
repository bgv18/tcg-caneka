namespace tcg_webApp.Domain
{
    public class Pokemon
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Supertype { get; set; }
        public List<string> Subtypes { get; set; } = new List<string>();
        public string Level { get; set; }
        public int Hp { get; set; }
        public List<string> Types { get; set; } = new List<string>();
        public string EvolvesFrom { get; set; }
        public object AncientTrait { get; set; } // Pode ser nulo ou ter uma estrutura específica
        public List<Ability> Abilities { get; set; } = new List<Ability>();
        public List<Attack> Attacks { get; set; } = new List<Attack>();
        public List<Weakness> Weaknesses { get; set; } = new List<Weakness>();
        public List<Resistance> Resistances { get; set; } = new List<Resistance>();
        public List<string> RetreatCost { get; set; } = new List<string>();
        public int ConvertedRetreatCost { get; set; }
        public Set Set { get; set; }
        public string Number { get; set; }
        public string Artist { get; set; }
        public string Rarity { get; set; }
        public List<int> NationalPokedexNumbers { get; set; } = new List<int>();
        public Legalities Legalities { get; set; }
        public PokemonImages Images { get; set; }
        public TcgPlayer TcgPlayer { get; set; }
        public CardMarket CardMarket { get; set; }
        public List<string> EvolvesTo { get; set; } = new List<string>();
        public string FlavorText { get; set; }
        public List<string> Rules { get; set; } = new List<string>();
        public string RegulationMark { get; set; }
    }

    // Classes auxiliares
    public class Ability
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
    }

    public class Attack
    {
        public string Name { get; set; }
        public List<string> Cost { get; set; } = new List<string>();
        public int ConvertedEnergyCost { get; set; }
        public string Damage { get; set; }
        public string Text { get; set; }
    }

    public class Weakness
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class Resistance
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class Set
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Series { get; set; }
        public int PrintedTotal { get; set; }
        public int Total { get; set; }
        public SetLegalities Legalities { get; set; }
        public string PtcgoCode { get; set; }
        public string ReleaseDate { get; set; }
        public string UpdatedAt { get; set; }
        public SetImages Images { get; set; }
    }

    public class SetLegalities
    {
        public string Unlimited { get; set; }
        public string Standard { get; set; }
        public string Expanded { get; set; }
    }

    public class SetImages
    {
        public string Symbol { get; set; }
        public string Logo { get; set; }
    }

    public class Legalities
    {
        public string Unlimited { get; set; }
        public string Standard { get; set; }
        public string Expanded { get; set; }
    }

    public class PokemonImages
    {
        public string Small { get; set; }
        public string Large { get; set; }
    }

    public class TcgPlayer
    {
        public string Url { get; set; }
        public string UpdatedAt { get; set; }
        public TcgPlayerPrices Prices { get; set; }
    }

    public class TcgPlayerPrices
    {
        public Price Holofoil { get; set; }
        public Price ReverseHolofoil { get; set; }
        public Price Normal { get; set; }
        public Price The1StEditionHolofoil { get; set; }
        public Price UnlimitedHolofoil { get; set; }
        public Price The1StEdition { get; set; }
        public Price Unlimited { get; set; }
    }

    public class Price
    {
        public decimal? Low { get; set; } = 0;
        public decimal? Mid { get; set; } = 0;
        public decimal? High { get; set; } = 0;
        public decimal? Market { get; set; } = 0;
        public decimal? DirectLow { get; set; } = 0;
    }

    public class CardMarket
    {
        public string Url { get; set; }
        public string UpdatedAt { get; set; }
        public CardMarketPrices Prices { get; set; }
    }

    public class CardMarketPrices
    {
        public decimal? AverageSellPrice { get; set; } = 0;
        public decimal? LowPrice { get; set; } = 0;
        public decimal? TrendPrice { get; set; } = 0;
        public decimal? ReverseHoloSell { get; set; } = 0;
        public decimal? ReverseHoloLow { get; set; } = 0;
        public decimal? ReverseHoloTrend { get; set; } = 0;
        public decimal? LowPriceExPlus { get; set; } = 0;
        public decimal? AverageDay { get; set; } = 0;
        public decimal? AverageWeek { get; set; } = 0;
        public decimal? AverageMonth { get; set; } = 0;
        public decimal? AverageDayReverseHolo { get; set; } = 0;
        public decimal? AverageWeekReverseHolo { get; set; } = 0;
        public decimal? AverageMonthReverseHolo { get; set; } = 0;
    }
}
