
using System;
using System.Linq;

namespace DurakClassLibrary
{
    public class PlayerHand : Deck
    {
        private int amountOfTrumpCards = 0;
        public int AmountOfTrumpCards { get => amountOfTrumpCards; set => amountOfTrumpCards = value; }

        public PlayerHand()
        {
        }

        public PlayerHand(Cards playerCards)
        {
            cards = playerCards;
            foreach (Card c in cards)
            {
                if (c.CardSuit == Table.GetTrumpSuit())
                {
                    AmountOfTrumpCards++;
                }
            }

            // Sort all the cards
            Sort();
        }

        public void AddHandCard(Card card)
        {
            cards.Add(card);
            if (card.CardSuit == Table.GetTrumpSuit())
            {
                AmountOfTrumpCards++;
            }

            // Sort all the cards
            Sort();
        }

        public void AddHandsCard(Cards cardsToAdd)
        {
            for (int i = 0; i < cardsToAdd.Count(); i++)
            {
                cards.Add(cardsToAdd[i]);
            }

            // Sort all the cards
            Sort();
        }

        public void AddHandsCard(PlayerHand hand)
        {
            Cards cardsToAdd = hand.GetCards();
            for (int i = 0; i < cardsToAdd.Count(); i++)
            {
                cards.Add(cardsToAdd[i]);
            }

            // Sort all the cards
            Sort();
        }

        public Card PickHandCard(Card card)
        {
            Card pickCard = card;
            cards.Remove(card);

            if (card.CardSuit == Table.GetTrumpSuit())
            {
                AmountOfTrumpCards--;
            }

            return pickCard;
        }


    }
}