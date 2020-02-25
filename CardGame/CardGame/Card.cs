namespace CardGame
{
    public class Card
    {
        public string Value { get; set; }

        public int Compare(Card other)
        {
            return GetValue() - other.GetValue();
        }

        public int GetValue()
        {
            if (int.TryParse(Value, out int value))
            {
                return value;
            }
            else
            {
                switch (Value)
                {
                    case "JACK":
                        return 12;
                    case "QUEEN":
                        return 13;
                    case "KING":
                        return 14;
                    case "ACE":
                        return 15;
                    default:
                        return 0;
                }
            }
        }
          
    }
}
