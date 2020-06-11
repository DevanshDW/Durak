using System;
using System.Collections.Generic;
using System.Text;

namespace DurakClassLibrary
{
    public class MachinePlayer : Player
    {
        public MachinePlayer()
        {

        }

        public MachinePlayer(PlayerHand myHand) : base(myHand)
        {
            
        }

        public Cards GetCards()
        {
            return Hand.GetCards();
        }

    }
}
