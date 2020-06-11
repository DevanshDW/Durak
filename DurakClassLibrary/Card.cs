using System;
using System.Drawing;

namespace DurakClassLibrary
{
    public class Card : ICloneable, IComparable
    {


        #region FIELDS AND PROPERRTIES

        protected Suit mySuit;
        public Suit CardSuit
        {
            get { return mySuit; } 
            set { mySuit = value; }
        }

        protected Rank myRank;
        public Rank CardRank
        {
            get { return myRank; } 
            set { myRank = value; }
        }



        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        #endregion


        #region  Constructors

       

        
        public Card(Suit suit = Suit.Hearts, Rank rank = Rank.Ace)
        {
            this.mySuit = suit;
            this.myRank = rank;
        }

        #endregion

        #region Public Methods

       
        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            string cardString;
            if (faceUp)
            {

                if (myRank == Rank.Joker)
                {
                    if (mySuit == Suit.Clubs || mySuit == Suit.Spades)
                    {

                        cardString = "Joker_Black";
                    }
                    else
                    {
                        cardString = "Joker_Red";
                    }
                }
                else
                {
                    cardString = myRank.ToString() + " of " + mySuit.ToString();
                }
            }
            else
            {
                cardString = "Face Down";
            }

            return cardString;

        }

        public override bool Equals(object card)
        {

            return this == (Card)card;
        }

        public override int GetHashCode()
        {

            return 13 * (int)this.mySuit + (int)this.myRank;
        }


        public Image GetCardImage()
        {
            string imageName; 
            Image cardImage; 
            if (!faceUp)
            {
                imageName = "Back";
            }
            else if (myRank == Rank.Joker)
            {
                if (mySuit == Suit.Clubs || mySuit == Suit.Spades)
                {
                    imageName = "Joker_Black";
                }
                else 
                {
                    imageName = "Joker_Red";
                }
            }
            else
            {
               
                imageName = mySuit.ToString() + "_" + myRank.ToString(); 
            }
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

            return cardImage;
        }


        
        public string DebugString()
        {   
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString()).PadLeft(20);
            cardState += (string)((FaceUp) ? "(Face Up)" : "(Face Down)").PadLeft(12);
            return cardState;
        }


       
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a Card to a null object.");
            }

            Card compareCard = obj as Card;   

        
                double thisSort = (double)this.myRank + ((double)this.mySuit * 20);
                double compareCardSort = (double)compareCard.myRank + ((double)compareCard.mySuit * 20);
                return (thisSort.CompareTo(compareCardSort));
           
        } 

        #endregion


        #region RELATIONAL OPERATORS

        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.mySuit == card2.mySuit) && (card1.myRank == card2.myRank);
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }



        public static bool operator >(Card card1, Card card2)
        {
            return (card1.myRank > card2.myRank);
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Card card1, Card card2)
        {
            return (card1.myRank >= card2.myRank);
        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

        #endregion





    }
}