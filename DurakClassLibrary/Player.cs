using System;
using System.Collections.Generic;
using System.Text;

namespace DurakClassLibrary
{
    public abstract class Player
    {
        private PlayerHand hand;
        private String name;

        public Player()
        {

        }

        public Player(PlayerHand myHand)
        {
            Hand = myHand;
            Name = RandomName();
        }

        public Player(String myName, PlayerHand myHand)
        {
            Hand = myHand;
            Name = myName;
        }

        public int GetNumberOfCardsOnHand()
        {
            return hand.GetCards().Count;
        }

        public string Name { get => name; set => name = value; }
        public PlayerHand Hand { get => hand; set => hand = value; }

        /// <summary>
        /// Generates a random String to be used as a Name
        /// </summary>
        /// <returns>a String to be used as a Name</returns>
        public static string RandomName(int len = 0)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }
    }
}
