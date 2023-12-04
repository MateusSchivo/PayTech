using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Paytech2023
{
    public partial class fmlHome : Form
    {
        public fmlHome()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            fmlCad telaCad = new fmlCad();

            telaCad.Show();

            this.Hide();
        }
        private void btnFP_Click(object sender, EventArgs e)
        {
            fmlFP telaFP = new fmlFP();

            telaFP.Show();

            this.Hide();
        }


    }
}
