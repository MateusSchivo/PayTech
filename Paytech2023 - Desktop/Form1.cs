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
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            string connectionString = @"Data Source=DESKTOP-ND0O9QK\SQLEXPRESSTESTE; integrated security=SSPI;initial catalog=PAYTECH_OFICIAL"; // Substitua pela sua string de conexão real

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Comando SQL para verificar o login e senha na tabela fmlLogin
                string query = "SELECT COUNT(*) FROM fmlLogin WHERE txtLogin = @txtLogin AND txtSenha = @txtSenha";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@txtLogin", login);
                    cmd.Parameters.AddWithValue("@txtSenha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Login bem-sucedido
                        MessageBox.Show("Login bem-sucedido!");

                        fmlHome telaHome = new fmlHome();
                        telaHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login inválido
                        MessageBox.Show("Login inválido. Verifique suas credenciais.");
                    }
                }
            }
        }





        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }


        private void fmlLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
