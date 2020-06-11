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
    public partial class frmUserGuide : Form
    {
        public frmUserGuide()
        {
            InitializeComponent();
        }

        private void UserGuide_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLetsPlayDurak letsPlayDurak = new frmLetsPlayDurak();
            letsPlayDurak.Show();
            this.Hide();
        }
    }
}
