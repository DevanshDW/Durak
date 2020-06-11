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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnThankYou_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
