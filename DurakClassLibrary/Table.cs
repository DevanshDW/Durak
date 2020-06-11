using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace DurakClassLibrary
{
    public class Table
    {
        private static Card trumpCard;
        private Cards discardPile = new Cards();
        private Cards attack = new Cards();
        private Cards defense = new Cards();

        public Deck deck;
        private static int attackCounter = 0;
        private static int defenseCounter = 0;

        HumanPlayer human;
        MachinePlayer computer;

        GameStage gameStage;

        public Card TrumpCard { get => trumpCard; }
        public GameStage GameStage { get => gameStage; set => gameStage = value; }
        public HumanPlayer Human { get => human; set => human = value; }
        public MachinePlayer Computer { get => computer; set => computer = value; }

        /// <summary>
        /// Create a standard table object
        /// </summary>
        public Table()
        {
            deck = new Deck(GameMode.Standard);
            deck.Shuffle();

            human = new HumanPlayer(DrawHand());  
            computer = new MachinePlayer(DrawHand());
        }

        public Table(GameMode game, int deckSize)
        {
            deck = new Deck(deckSize);
            deck.Shuffle();
            trumpCard = deck.GetCard(deck.GetNumberOfCards() - 1);  

            human = new HumanPlayer(DrawHand());
            computer = new MachinePlayer(DrawHand());

            //!!!!-- Needs to be changed so that player with lowest trump goes first --!!!!
            Random rand = new Random(); 
            if ((int)rand.Next() % 2 == 0)
            {
                gameStage = GameStage.HumanAttack;
            }
            else
            {
                gameStage = GameStage.MachineAttack;
            }
        }

        public PlayerHand DrawHand(int numOfCards = 6)
        {
            PlayerHand myHand = new PlayerHand();
            for (int i = 0; i < numOfCards; i++)
            {
                try
                {
                    myHand.AddHandCard(DrawCard());
                }
                catch (NoCardsToReturnException)
                {
                    i = numOfCards;   

                    if (myHand.GetNumberOfCards() == 0)
                    {
                        throw new NoCardsToReturnException();
                    }
                }
                
            }
            return myHand;
        }

        public bool MakeAttack(Player player, Card receiveCard)
        {
            Boolean cardIsOK = CheckAttack(receiveCard);

            if (cardIsOK)  
            {
                attack.Add(receiveCard);
                attackCounter++;

                player.Hand.PickHandCard(receiveCard);
            } 

            return cardIsOK;

        }

        public bool CheckAttack(Card receiveCard)
        {
            bool cardIsOK = false;

            if (attackCounter != 0)
            {
                foreach (Card c in attack)
                {
                    if (receiveCard.CardRank == c.CardRank)
                    {
                        cardIsOK = true;
                    }
                }
                foreach (Card c in defense)
                {
                    if (receiveCard.CardRank == c.CardRank)
                    {
                        cardIsOK = true;
                    }
                }
            }
            else    
            {
                cardIsOK = true;
            }

            return cardIsOK;

        }

        public bool CheckDefense()
        {
            bool result = true;
            for (int i = 0; i < defense.Count; i++)
            {
                if (attack[i].CardSuit == defense[i].CardSuit)
                {
                    if (attack[i] > defense[i])
                    {
                        result = false;
                        i = defense.Count;
                    }
                }
                else if (defense[i].CardSuit != trumpCard.CardSuit)
                {
                    result = false;
                    i = defense.Count;
                }
            }
            return result;
        }

        public bool MakeDefense(Player player, Card receiveCard)
        {
            bool result = false;
            defense.Add(receiveCard);
            defenseCounter++;

            if (CheckDefense())
            { 
                result = true;

                player.Hand.PickHandCard(receiveCard);
            }
            else
            {
                defense.Remove(receiveCard);
                defenseCounter--;
            }

            return result;
        }

        public void Reset()
        {
            attackCounter = 0;
            defenseCounter = 0;

        }

        public Cards EndRound(bool defenseWonRound)
        {
            Cards result = new Cards();

            if (defenseWonRound)
            {
                foreach (Card c in defense)
                {
                    discardPile.Add(c);
                }

                foreach (Card c in attack)
                {
                    discardPile.Add(c);
                }

                defense = new Cards();
                attack = new Cards(); 
            }
            else    
            {
                foreach (Card c in attack)
                {
                    result.Add(c);
                }
                foreach (Card c in defense)
                {
                    result.Add(c);
                }

                defense = new Cards();
                attack = new Cards();

                if (GameStage == GameStage.MachineDefense)
                {
                    Computer.Hand.AddHandsCard(result);
                }
                else if (GameStage == GameStage.HumanDefense)
                {
                    Human.Hand.AddHandsCard(result);
                }
            }

            Reset();   

            
            

            return result;

        }

        public void CompletePlayerHand(Player player)
        {
            int numberOfCards = 6 - player.GetNumberOfCardsOnHand();

            if (numberOfCards > 0)
            {
                player.Hand.AddHandsCard(DrawHand(numberOfCards));
            }
        }

        public Card DrawCard(int cardPosition = 0)
        {
            Card returnCard = deck.DrawCard(cardPosition);

            if (deck.GetNumberOfCards() == 1)
            {
                if (this.EmptydDeck != null)
                    this.EmptydDeck((object)this, new EventArgs());
            }
            if (deck.GetNumberOfCards() == 0)
            {
                if (this.NoTrump != null)
                    this.NoTrump((object)this, new EventArgs());
            }

            return returnCard;
        }


        public static Suit? GetTrumpSuit()
        {
            //changed
            return Suit.Clubs;

        }


        public PlayerHand GetHumanHand()
        {
            return human.Hand;
        }


        public PlayerHand GetMachineHand()
        {
            return computer.Hand;
        }

        public Card MachineAttack()
        {
            Card lowestRankCardOK = new Card(Suit.Spades, Rank.Ace);
            bool foundOKCard = false;
            int counter = 0;

            foreach (Card c in computer.GetCards())
            {
                if (c.CardSuit != Table.GetTrumpSuit())
                {
                    counter++;
                    if (c.CardRank <= lowestRankCardOK.CardRank)
                    {
                        if(CheckAttack(c))
                        {
                            lowestRankCardOK = c;
                            foundOKCard = true;
                        }
                    }
                }
            }

            // If all cards are trumps, return the lowest trump card
            if (counter == 0)
            {
                foreach (Card c in computer.GetCards())
                {
                    if (c.CardRank <= lowestRankCardOK.CardRank)
                    {
                        // Check if this is a valid attack
                        if (CheckAttack(c))
                        {
                            lowestRankCardOK = c;
                            foundOKCard = true;
                        }
                    }
                }
            }

            if (foundOKCard)
            {
                MakeAttack(Computer, lowestRankCardOK);
            }
            else
            {
                throw new NoOKCardException();
            }

            return lowestRankCardOK;
        }

        public Card MachineDefense(Card attackCard)
        {
            Card lowestRankCardOK = new Card(Suit.Spades, Rank.Ace);
            bool foundOKCard = false;

            foreach (Card c in computer.GetCards())
            {
                if (c.CardSuit == attackCard.CardSuit)
                {
                    if (c.CardRank > attackCard.CardRank && 
                        c.CardRank <= lowestRankCardOK.CardRank)
                    {
                        lowestRankCardOK = c;
                        foundOKCard = true;
                    }
                }
            }


            if (!foundOKCard && attackCard.CardSuit != trumpCard.CardSuit)
            {
                foreach (Card c in computer.GetCards())
                {
                    if (c.CardSuit == trumpCard.CardSuit)
                    {
                        if (c.CardRank <= lowestRankCardOK.CardRank)
                        {
                            lowestRankCardOK = c;
                            foundOKCard = true;
                        }
                    }
                }
            }

            if (foundOKCard)
            {
                MakeDefense(Computer, lowestRankCardOK);
            }
            else
            {
                throw new NoOKCardException();
            }

            return lowestRankCardOK;
        }

        public event EventHandler EmptydDeck;

        public event EventHandler NoTrump;

    }


    public enum GameStage
    {
        HumanAttack,
        MachineDefense,
        MachineAttack,
        HumanDefense
    }
}
