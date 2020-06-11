

using System;

namespace DurakClassLibrary
{
    public class Deck : ICloneable
    {
        protected Cards cards = new Cards();
        private int numberOfCards = 0;

        protected int NumberOfCards { get => numberOfCards; set => numberOfCards = value; }

        public Deck(Cards newCards)
        {
            cards = newCards;
            numberOfCards = cards.Count;
        }

        public Deck()
        {
        }

        
        public Deck(GameMode gameMode)
        {
            switch (gameMode)
            {
                case GameMode.Standard:
                    {
                        for (int suitVal = 0; suitVal < 4; suitVal++)
                        {
                            for (int rankVal = 2; rankVal < 15; rankVal++)
                            {
                                cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                            }
                        }
                        numberOfCards = cards.Count;
                        break;
                    }
                case GameMode.Durak:
                    {
                        for (int suitVal = 0; suitVal < 4; suitVal++)
                        {
                            for (int rankVal = 6; rankVal < 15; rankVal++)
                            {
                                cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                            }
                        }
                        numberOfCards = cards.Count;
                        break;
                    }
            } 
        } 

        public Deck(int deckSize)
        {

            int minRank = 36;

            switch (deckSize)
            {
                case 20:
                    {
                        minRank = 10;
                        break;
                    }
                case 36:
                    {
                        minRank = 6;
                        break;
                    }
                case 52:
                    {
                        minRank = 2;
                        break;
                    }
            }

            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = minRank; rankVal < 15; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
            numberOfCards = cards.Count;
        }

        public int GetNumberOfCards()
        {
            return numberOfCards;
        }

        public Card GetCard(int cardNum = 0)
        {
            if (cardNum >= 0 && cardNum <= cards.Count - 1)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardnum", cardNum,
                        "value must be between 0 and " + (cards.Count - 1) + "."));
        }
        public Card DrawCard(int cardNum = 0)
        {
                if (numberOfCards > 0)
                {
                    Card drawCard = cards[cardNum];
                    cards.RemoveAt(cardNum);
                    numberOfCards = cards.Count;

                    return drawCard;
                }
                else
                    throw new NoCardsToReturnException();
        }


        public Cards GetCards()
        {
            return cards;
        }

        public void Shuffle()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);

            int randomPosition = 0;

            cards.Clear();

            Random randomNumber = new Random();

            for (int i = newDeck.GetCards().Count; i > 0; i--)
            {
                randomPosition = randomNumber.Next(newDeck.GetCards().Count);
                cards.Add(newDeck.GetCards()[randomPosition]);
                newDeck.GetCards().RemoveAt(randomPosition);
            }
        }

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }

        public void Sort()
        {
            cards.Sort();
        }

    }
}