using Newtonsoft.Json;

namespace CardGame
{
    public class Deck
    {
        [JsonProperty("deck_id")]
        public string DeckId { get; set; }
    }
}
