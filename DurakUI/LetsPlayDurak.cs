using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakClassLibrary;

namespace DurakUI
{
    public partial class frmLetsPlayDurak : MyForm
    {

        public frmLetsPlayDurak()
        {
            InitializeComponent();
            //set player name
            if (playerName != null)
            {
                txtName.Text = playerName;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //takes user to settings menu
            playerName = txtName.Text;
            frmGameSetting gameSetting = new frmGameSetting();
            gameSetting.Show();
            this.Hide();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            //begins game
            playerName = txtName.Text;
            frmPlayTime PlayTime = new frmPlayTime();
            PlayTime.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit app
            this.Close();
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //takes user to info screen
            frmUserGuide UserGuid = new frmUserGuide();
            UserGuid.Show();
            this.Hide();
        }
    }
}
