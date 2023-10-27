using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paytech2023
{
    public partial class fmlLogin : Form
    {
        public fmlLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Crie uma instância da tela fmlHome
            fmlHome telaHome = new fmlHome();

            // Mostre a tela fmlHome
            telaHome.Show();

            // Ou, se desejar fechar a tela de login ao abrir a tela fmlHome
            this.Hide();
        }

    }
}
