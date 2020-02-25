using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace CardGame
{
    internal class CardService : ICardService
    {
        private const string Api = "https://deckofcardsapi.com/api/";
        private const string DeckEndpoint = "deck/new/shuffle/?deck_count=1";
        private const string DrawEndpoint = "deck/{0}/draw/?count={1}";

        public List<Card> DrawCards(Deck deck, int count)
        {
            string drawEndpoint = string.Format(DrawEndpoint, deck.DeckId, count);

            using (WebClient webClient = new WebClient())
            {
                string response = webClient.DownloadString(Api + drawEndpoint);

                DrawResponse drawResponse = JsonConvert.DeserializeObject<DrawResponse>(response);

                return drawResponse.Cards;
            }
        }

        public Deck GetDeck()
        {
            using (WebClient webClient = new WebClient())
            {
                string response = webClient.DownloadString(Api + DeckEndpoint);

                return JsonConvert.DeserializeObject<Deck>(response);
            }
        }
    }
}
