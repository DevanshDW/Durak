using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DurakClassLibrary;
using TheCardBox;

namespace DurakUI
{
    public class MyForm : Form
    {
        protected static string playerName = null;
        protected static int deckSize = 36;
        protected static Image pictureColor = (new Card()).GetCardImage();

        protected static DeckColors deckColor = DeckColors.red;

        protected enum DeckColors
        {
            red,
            blue,
            green,
            yellow,
            grey
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Name = "MyForm";
            this.ResumeLayout(false);

        }
    }
}
