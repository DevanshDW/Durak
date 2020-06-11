using System;
using System.Drawing;
using System.Windows.Forms;
using DurakClassLibrary;
using TheCardBox;

namespace DurakUI
{
    public partial class frmPlayTime : MyForm
    {

        #region FIELDS AND PROPERTIES

        /// <summary>
        /// The amount, in points, that CardBox controls are enlarged when hovered over. 
        /// </summary>
        private const int POP = 25;

        /// <summary>
        /// The amount of attack cards on the table
        /// </summary>
        private int countAttacks = 0;

        /// <summary>
        /// The amount of defense cards on the table
        /// </summary>
        private int countDefenses = 0;

        /// <summary>
        /// The regular size of a CardBox control
        /// </summary>
        static private Size regularSize = new Size(152, 216);


        /// <summary>
        /// Used to manage the game
        /// </summary>
        private Table table;

        #endregion

        #region FORM AND STATIC CONTROL EVENT HANDLERS


        public frmPlayTime()
        {
            InitializeComponent();

            table = new Table(GameMode.Durak, deckSize);

            lblDeckCounter.Text = (deckSize - 12).ToString();

            Card trumpCard = table.TrumpCard;
            trumpCard.FaceUp = true;
            pbTrump.Image = trumpCard.GetCardImage();
            pbTrump.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            pbDeck.Image = pictureColor;   
            pbDiscard.Image = null; ;    

            RealignAll();

            if (table.GameStage == GameStage.MachineAttack)
            {
                ProcessTurn(new TheCardBox.CardBox());  
            }

            lblComputerName.Text = "CPU";

            lblHumanName.Text = playerName;

            if (playerName == "Insert Your Name Here")
            {
                lblHumanName.Text = "Player";
            }
            

        }


        private void frmPlayTime_Load(object sender, EventArgs e)
        {

            // Set the deck image to a card back image
            table.EmptydDeck += Table_EmptyDeck;
            table.NoTrump += Table_NoTrump;
        }

        private void Table_EmptyDeck(object sender, EventArgs e)
        {
            //cbxDeck.EmptyCardImage(false);
            pbDeck.Image = null;
        }

        private void Table_NoTrump(object sender, EventArgs e)
        {
            //cbxDeck.EmptyCardImage(true);
            pbTrump.Image = null;

            Image suitImage = Properties.Resources.ResourceManager.GetObject(table.TrumpCard.CardSuit.ToString()) as Image;
            pbDeck.Image = suitImage;
        }

        /// <summary>
        /// Repositions the cards in a panel so that they are evenly distributed in the area available.
        /// </summary>
        /// <param name="panelHand"></param>
        /// <param name="fromTop"></param>
        /// Reference: See method created by Thom McDonald on https://www.youtube.com/watch?v=D1LWDseWHvs&feature=youtu.be&list=PLfNfAX7mRzNrF6dkHk31E4xEINXUFe5IM&t=98
        private void RealignHand(Panel panelHand, int fromTop = POP)
        {
            // Determine the number of cards/controls in the panel.
            int myCount = panelHand.Controls.Count;

            // If there are any cards in the panel
            if (myCount > 0)
            {
                // Determine how wide one card/control is.
                int cardWidth = panelHand.Controls[0].Width;

                // Determine where the left-hand edge of a card/control placed 
                // in the middle of the panel should be  
                int startPoint = (panelHand.Width - cardWidth) / 2;

                // An offset for the remaining cards
                int offset = 0;

                // If there are more than one cards/controls in the panel
                if (myCount > 1)
                {
                    // Determine what the offset should be for each card based on the 
                    // space available and the number of card/controls
                    offset = (panelHand.Width - cardWidth - 2 * POP) / (myCount - 1);

                    // If the offset is bigger than the card/control width, i.e. there is lots of room, 
                    // set the offset to the card width. The cards/controls will not overlap at all.
                    if (offset > cardWidth)
                        offset = cardWidth;

                    // Determine width of all the cards/controls 
                    int allCardsWidth = (myCount - 1) * offset + cardWidth;

                    // Set the start point to where the left-hand edge of the "first" card should be.
                    startPoint = (panelHand.Width - allCardsWidth) / 2;
                }
                // Aligning the cards: Note that I align them in reserve order from how they
                // are stored in the controls collection. This is so that cards on the left 
                // appear underneath cards to the right. This allows the user to see the rank
                // and suit more easily.

                // Align the "first" card (which is the last control in the collection)
                panelHand.Controls[myCount - 1].Top = fromTop;
                //System.Diagnostics.Debug.Write(panelHand.Controls[myCount - 1].Top.ToString() + "\n");  // for debug
                panelHand.Controls[myCount - 1].Left = startPoint;

                // for each of the remaining controls, in reverse order.
                for (int index = myCount - 2; index >= 0; index--)
                {
                    // Align the current card
                    panelHand.Controls[index].Top = fromTop;
                    panelHand.Controls[index].Left = panelHand.Controls[index + 1].Left + offset;
                }
            }
        }

        /// <summary>
        /// Realign human and computer panels on screen
        /// </summary>
        private void RealignAll()
        {
            PlayerHand humanHand = table.GetHumanHand();
            pnlHuman.Controls.Clear();
            foreach (Card c in humanHand.GetCards())
            {
                c.FaceUp = true;
                TheCardBox.CardBox cardBox = new TheCardBox.CardBox(c);
                cardBox.Click += CardBox_Click;

                pnlHuman.Controls.Add(cardBox);
                RealignHand(pnlHuman);
            }

            PlayerHand machineHand = table.GetMachineHand();
            pnlMachine.Controls.Clear();
            foreach (Card c in machineHand.GetCards())
            {
                c.FaceUp = false;
                TheCardBox.CardBox cardBox = new TheCardBox.CardBox(c);
                pnlMachine.Controls.Add(cardBox);
                RealignHand(pnlMachine, 0);
            }
        }

        /// <summary>
        /// Repositions the cards in the table to indicate an attack / defense correctly
        /// </summary>
        private void AddCardToTable(TheCardBox.CardBox aCardBox, bool isAttack)
        {
            pnlTable.Controls.Add(aCardBox);

            // Determine the number of cards/controls in the panel, after creating the last control
            int myCount = pnlTable.Controls.Count;

            if (isAttack)
            {
                pnlTable.Controls[myCount - 1].Top = 0;    // Attack cards are at the top of the panel
                pnlTable.Controls[myCount - 1].Left = countAttacks * 130;       // 176 is the magical number to allow a good visual position

                countAttacks++;
            }
            else    // It is a defense
            {
                pnlTable.Controls[myCount - 1].Top = 60;    // 80 is the vertical position of the defense card
                pnlTable.Controls[myCount - 1].Left = 16 + countDefenses * 130;       // 176 is the magical number to allow a good visual position and 16 is the good initial horizontal position
                pnlTable.Controls[myCount - 1].BringToFront();

                countDefenses++;
            }
            
        }

        /// <summary>
        /// This process the human and the machine turn, in this order
        /// </summary>
        /// <param name="aCardBox"></param>
        private void ProcessTurn(TheCardBox.CardBox aCardBox)
        {
            System.Diagnostics.Debug.Write(table.GameStage + "\n");
            // if the card is in the human panel...
            if (aCardBox.Parent == pnlHuman)
            {
                // Identify if it is attack or defense
                bool isAttack;
                if (table.GameStage == GameStage.HumanAttack)
                {
                    isAttack = true;
                    if (table.MakeAttack(table.Human, aCardBox.Card))
                    {
                        // Change to machine defense if the attack was a valid card, otherwise keep waiting for card
                        table.GameStage = GameStage.MachineDefense;

                        // Add the control to the table panel
                        AddCardToTable(aCardBox, isAttack);
                        // Remove the card from the human panel
                        pnlHuman.Controls.Remove(aCardBox);
                        // Realign the cards
                        RealignHand(pnlHuman);
                    }
                }
                else   // table.GameStage == GameStage.HumanDefense
                {
                    isAttack = false;
                    if (table.MakeDefense(table.Human, aCardBox.Card))
                    {
                        // Change to machine attack if the defense was a valid card, otherwise keep waiting for card
                        table.GameStage = GameStage.MachineAttack;

                        // Add the control to the table panel
                        AddCardToTable(aCardBox, isAttack);
                        // Remove the card from the human panel
                        pnlHuman.Controls.Remove(aCardBox);
                        // Realign the cards
                        RealignHand(pnlHuman);
                    }
                }

            }

            // If it is Machine turn
            if (table.GameStage == GameStage.MachineAttack)
            {
                try
                {
                    // Select next attack card and move it to the table
                    Card machineCard = table.MachineAttack();
                    foreach(Control control in pnlMachine.Controls)
                    {
                        TheCardBox.CardBox cardBox = (TheCardBox.CardBox)control;
                        if (cardBox != null)  // which means the control is a cardBox
                        {
                            if(cardBox.Card == machineCard)   // Look for which cardBox has the selected card
                            {
                                // Flip this card to show its value
                                cardBox.FaceUp = true;
                                // Add this cardbox to the table panel
                                AddCardToTable(cardBox, true);

                                // Remove the card from the computer panel
                                pnlMachine.Controls.Remove(cardBox);
                                // Realign the cards
                                RealignHand(pnlMachine);
                            }
                        }
                    }

                    // Allow the human to defend it
                    table.GameStage = GameStage.HumanDefense;

                }
                catch (NoOKCardException)  // If the machine player has no more good cards to play
                {
                    // End turn
                    EndTurn(true);   // true because in this case, defense won because the machine do not have more good cards to attack
                    RealignAll();    // REalign all cards on the screen
                }

            }

            if (table.GameStage == GameStage.MachineDefense)
            {
                try
                {
                    // Select the defense card and move it to the table
                    Card machineCard = table.MachineDefense(aCardBox.Card);
                    foreach (Control control in pnlMachine.Controls)
                    {
                        TheCardBox.CardBox cardBox = (TheCardBox.CardBox)control;
                        if (cardBox != null)  // which means the control is a cardBox
                        {
                            if (cardBox.Card == machineCard)   // Look for which cardBox has the selected card
                            {
                                // Flip this card to show its value
                                cardBox.FaceUp = true;
                                // Add this cardbox to the table panel
                                AddCardToTable(cardBox, false);

                                // Remove the card from the computer panel
                                pnlMachine.Controls.Remove(cardBox);
                                // Realign the cards
                                RealignHand(pnlMachine);
                            }
                        }
                    }

                    // Allow the human to defend it
                    table.GameStage = GameStage.HumanAttack;

                }
                catch (NoOKCardException)  // If the machine player has no more good cards to play
                {
                    // End turn
                    EndTurn(false);   // false because in this case, defense lose because the machine do not have more good cards to defend
                    RealignAll();    // Realign all cards on the screen
                }
            }
            System.Diagnostics.Debug.Write(table.GameStage + "\n");
        }

        private void EndTurn(bool defenseWonRound)
        {
            Cards tableCards = new Cards();

            // End turn on the table class
            tableCards = table.EndRound(defenseWonRound);  // tableCards will only have cards if defenseWonRound is false

            // End turn on the screen - clear table
            pnlTable.Controls.Clear();   // Remove all controls from the table panel
            countAttacks = 0;
            countDefenses = 0;

            if (defenseWonRound)
            {
                pbDiscard.Image = pictureColor;     // A new card will be created with face down, so the Discard pile will have the back image
            }
            else   // defenseWonRound is false, means the attack won the turn
            {
                // If the attack won, there is new cards on the hand of the defender, so we need to realing it
                RealignAll();
            }

            // Complete players hands with cards until 6 cards (do not draw cards if hand has more then 6 cards already)
            try
            {
                // Add the cards to the attacker first, then the defender
                if (table.GameStage == GameStage.MachineAttack ||
                    table.GameStage == GameStage.HumanDefense)
                {
                    table.CompletePlayerHand(table.Computer);
                    table.CompletePlayerHand(table.Human);
                }
                else if (table.GameStage == GameStage.HumanAttack ||
                         table.GameStage == GameStage.MachineDefense)
                {
                    table.CompletePlayerHand(table.Human);
                    table.CompletePlayerHand(table.Computer);
                }

                // Set the Deck counter to the new number
                lblDeckCounter.Text = table.deck.GetNumberOfCards().ToString();
            }
            catch (NoCardsToReturnException)
            {
                if (table.Human.GetNumberOfCardsOnHand() == 0)
                {
                    // human won
                    MessageBox.Show("Human won");
                }
                if (table.Computer.GetNumberOfCardsOnHand() == 0)
                {
                    // machine won
                    MessageBox.Show("Human won");
                }
            }

            RealignAll();    // Realign human and machine panels

            // Define next attacker
            if (defenseWonRound)
            {
                // If the defense won last round, so now they are the attacker
                if (table.GameStage == GameStage.HumanDefense)
                    table.GameStage = GameStage.HumanAttack;

                if (table.GameStage == GameStage.MachineDefense)
                    table.GameStage = GameStage.MachineAttack;

                if (table.GameStage == GameStage.MachineAttack)
                    table.GameStage = GameStage.HumanAttack;

            }
            else    // Attacker won last round
            {
                // IF the attacker won, then he keeps attacking
                if (table.GameStage == GameStage.HumanDefense)
                    table.GameStage = GameStage.MachineAttack;

                if (table.GameStage == GameStage.MachineDefense)
                    table.GameStage = GameStage.HumanAttack;
            }

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            if (table.GameStage == GameStage.HumanAttack)
            {
                EndTurn(true);
            }
            else   // (table.GameStage == GameStage.HumanDefense)
            {
                EndTurn(false);
            }

            RealignAll();    // Realign all cards on the screen

            // After the human player click on the button, it will always be the machine turn to attack
            table.GameStage = GameStage.MachineAttack;
            ProcessTurn(new TheCardBox.CardBox());   // Since it is Machine turn, doesn't matter the cardBox, so I am creating a new one
        }

        private void CardBox_Click(object sender, EventArgs e)
        {
            // Convert sender to a CardBox
            TheCardBox.CardBox aCardBox = sender as TheCardBox.CardBox;

            // If the conversion worked
            if (aCardBox != null)
            {
                ProcessTurn(aCardBox);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //return to menu
            frmLetsPlayDurak letsPlayDurak = new frmLetsPlayDurak();
            letsPlayDurak.Show();
            this.Hide();
        }
    }

    #endregion
}

