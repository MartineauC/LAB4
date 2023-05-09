using System;

namespace CardClasses
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();

        private int value;
        private int suit;

        public Card()
        {
            value = generator.Next(1, 14);
            suit = generator.Next(1, 5);
        }

        public Card(int value, int suit)
        {
            if (IsValidValue(value) && IsValidSuit(suit))
            {
                this.value = value;
                this.suit = suit;
            }
            else
            {
                throw new ArgumentException("Invalid card value or suit.");
            }
        }

        public int Value
        {
            get { return value; }
            set
            {
                if (IsValidValue(value))
                {
                    this.value = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid card value.");
                }
            }
        }

        public int Suit
        {
            get { return suit; }
            set
            {
                if (IsValidSuit(value))
                {
                    suit = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid card suit.");
                }
            }
        }

        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }

        public bool IsRed()
        {
            return suit == 2 || suit == 3;
        }

        public bool IsBlack()
        {
            return suit == 1 || suit == 4;
        }

        public bool IsClub()
        {
            return suit == 1;
        }

        public bool IsDiamond()
        {
            return suit == 2;
        }

        public bool IsHeart()
        {
            return suit == 3;
        }

        public bool IsSpade()
        {
            return suit == 4;
        }

        public bool IsAce()
        {
            return value == 1;
        }

        public bool IsFaceCard()
        {
            return value >= 11 && value <= 13;
        }

        public bool HasSameSuit(Card otherCard)
        {
            return suit == otherCard.suit;
        }

        public bool HasSameValue(Card otherCard)
        {
            return value == otherCard.value;
        }

        private static bool IsValidValue(int value)
        {
            return value >= 1 && value <= 13;
        }

        private static bool IsValidSuit(int suit)
        {
            return suit >= 1 && suit <= 4;
        }
    }
}