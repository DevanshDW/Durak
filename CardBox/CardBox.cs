/**
 * CardBox.cs - The CardBox Class
 * 
 * @author      Thom MacDonald
 *              Devansh Patel
 * @version     1.0
 * @since       2019-02-22  
 * @see         <videolink>
 * @see:        <http://en.wikipedia.org/wiki/Playing_card#French_design>
 *  
 */


using System;
using System.Windows.Forms;
using System.Drawing;
using DurakClassLibrary;
using System.ComponentModel;

namespace TheCardBox
{
    /// <summary>
    /// A control to use in a Windows Forms Application that displays a playing card.
    /// </summary>
    public partial class CardBox : UserControl
    {


        #region FIELDS AND PROPERTIES



        /// <summary>
        /// Card Property: sets/ gets the underlying Card object
        /// </summary>
        private Card myCard;
        public Card Card
        {
            set
            {
                myCard = value;
                pbMyPictureBox.Image = myCard.GetCardImage(); // Update the card Image
                UpdateCardImage(); // update the card image
            }
            get { return myCard; }
        }

        /// <summary>
        /// Suit Property: sets/gets the underlying Card object's Suit.
        /// </summary>
        public Suit Suit
        {
            set
            {
                Card.CardSuit = value;
                UpdateCardImage(); // update the card image

            }
            get { return Card.CardSuit; }
        }


        /// <summary>
        /// Rank Property: sets/gets the underlying Card object's Rank.
        /// </summary>
        public Rank Rank
        {
            set
            {
                Card.CardRank = value;
                UpdateCardImage(); // update the card image

            }
            get { return Card.CardRank; }
        }

        /// <summary>
        /// FaceUp Property: sets/gets the underlying Card object's FaceUp property.
        /// </summary>
        public bool FaceUp
        {
            set
            {
                // if value is diffrent than the underlying card's FaceUp property
                if (myCard.FaceUp != value) // then the card is flipping over
                {
                    myCard.FaceUp = value; // change the card's FaceUp property

                    UpdateCardImage(); // update the card image (back of front)

                    // if there is an event handler for CardFlipped in the client program
                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs()); // call it
                }
            }
            get { return Card.FaceUp; }
        }

        /// <summary>
        /// CardOrientatino Property: sets/gets the orientation of the card
        /// If setting this property changes the state of the control, swaps
        /// the height and width of the control and updates the image.
        /// </summary>
        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                // if value is different than myOrientation
                if (myOrientation != value)
                {
                    myOrientation = value;  // change the orientation
                    // swap the height and width of the control
                    Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage(); // update the card image

                }
            }
            get { return myOrientation; }
        }


        private void UpdateCardImage()
        {
            // set the image using the underlying card
            pbMyPictureBox.Image = myCard.GetCardImage();

            // if the orientation is horizontal
            if (myOrientation == Orientation.Horizontal)
            {
                //rotate the image
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        /// <summary>
        /// Clear image of the CardBox
        /// </summary>
        public void EmptyCardImage(Boolean isTrump)
        {
            if (isTrump)
            {
                // set the image to only the suit
                pbMyPictureBox.Image = null;            // Add image hereeeeeeeeee
            }
            else
            {
                // set the image to null
                pbMyPictureBox.Image = null;
            }
            
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Constructor (Default): Constucts the control with a new card, oriented vertically
        /// </summary>
        public CardBox()
        {
            InitializeComponent();  // required method for Designer support.
            myOrientation = Orientation.Vertical; // set the orientation to vertical.
            Card = new Card(); // create a new underlying card.
        }

        /// <summary>
        /// Constructor (PlayingCard, Orientation) : Constructs the contorl using paramters
        /// </summary>
        /// <param name="card">Underlying PlayingCard object</param>
        /// <param name="orientation">Orientation enumertaion. Vertical by default</param>
        public CardBox(Card card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent(); // required mthod for Designer support
            myOrientation = orientation; // set the orientation
            myCard = card; // set the underlying card.
        }   


        #endregion

        #region EVENTS AND EVENT HANDLERS

        /// <summary>
        /// An event handler for the load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage(); // Update the card image
        }

        /// <summary>
        /// An event the client program can handle when the card flips face up/down
        /// </summary>
        public event EventHandler CardFlipped;


        /// <summary>
        /// An event the client program can handle when the user clicks the control
        /// </summary>
        new public event EventHandler Click;

        /// <summary>
        /// An evnet handler for the user clicking the picturebox control uses the delegate system event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            if (Click != null) // If there is a handler for clicking the control in the client program
                Click(this, e); // call it
        }


        public new event EventHandler MouseEnter;

        private void pbMyPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (MouseEnter == null)
                return;
            MouseEnter((object)this, e);
        }

        public new event EventHandler MouseLeave;

        private void pbMyPictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (MouseLeave == null)
                return;
            MouseLeave((object)this, e);
        }

        public new event MouseEventHandler MouseDown;

        private void pbMyPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseDown == null)
                return;
            MouseDown((object)this, e);
        }



        #endregion

        #region OTHER METOHDS

        /// <summary>
        /// ToString: Overrides System.Object.ToString()
        /// </summary>
        /// <returns>The name of the card as a string</returns>
        public override string ToString()
        {
            return myCard.ToString();
        }



        #endregion


    }
}
