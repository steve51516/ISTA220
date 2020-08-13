namespace Cards
{
	class PlayingCard
	{
        private readonly Suit suit;
        private readonly Value value;

		public PlayingCard(Suit s, Value v)
		{
			suit = s;
			value = v;
		}

        public override string ToString()
		{
            string result = $"{value} of {suit}";
            return result;
		}

        public Suit CardSuit()
        {
            return suit;
        }

        public Value CardValue()
        {
            return value;
        }
	}
}