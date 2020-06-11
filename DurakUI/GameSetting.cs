using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakUI
{
    public partial class frmGameSetting : MyForm
    {
        public frmGameSetting()
        {
            InitializeComponent();

            //Check state of deckSize
            if (deckSize == 20)
            {
                rdo20Cards.Checked = true;
            }
            else if (deckSize == 36)
            {
                rdo36Cards.Checked = true;
            }
            else if (deckSize == 52)
            {
                rdo52Cards.Checked = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Get selected deckSize
            if (rdo20Cards.Checked)
                deckSize = 20;
            else if (rdo36Cards.Checked)
                deckSize = 36;
            else if (rdo52Cards.Checked)
                deckSize = 52;


            frmLetsPlayDurak frmLetsPlay = new frmLetsPlayDurak();
            frmLetsPlay.Show();
            this.Close();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {

        }
    }
}
