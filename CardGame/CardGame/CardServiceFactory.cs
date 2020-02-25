namespace CardGame
{
    public class CardServiceFactory
    {
        public static ICardService GetCardService()
        {
            return new CardService();
        }
    }
}
