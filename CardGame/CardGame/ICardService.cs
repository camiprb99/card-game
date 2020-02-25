using System.Collections.Generic;

namespace CardGame
{
    public interface ICardService
    {
        Deck GetDeck();
        List<Card> DrawCards(Deck deck, int count);
    }
}
