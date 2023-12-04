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
    public partial class fmlFP : Form
    {
        public fmlFP()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarFP_Click(object sender, EventArgs e)
        {
            fmlHome telaHome = new fmlHome();

            telaHome.Show();

            this.Hide();
        }

        // Pesquisa o email cadastrado e gera as informações
        private void txtEmaFP_TextChanged(object sender, EventArgs e)
        {

        }

        // Pesquisa o email cadastrado e gera as informações
        private void btnGerar_Click(object sender, EventArgs e)
        {
            string email = txtEmaFP.Text;

            string connectionString = @"Data Source=DESKTOP-ND0O9QK\SQLEXPRESSTESTE; integrated security=SSPI;initial catalog=PAYTECH_OFICIAL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkExistingQuery = "SELECT COUNT(*) FROM fmlFP WHERE txtEmaFP = @Email";
                using (SqlCommand cmdCheckExisting = new SqlCommand(checkExistingQuery, connection))
                {
                    cmdCheckExisting.Parameters.AddWithValue("@Email", email);
                    int existingCount = Convert.ToInt32(cmdCheckExisting.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        CarregarInformacoesExistente(email, connection);
                    }
                    else
                    {
                        GerarNovasInformacoes(email, connection);
                    }
                }
            }
        }


        private void CarregarInformacoesExistente(string email, SqlConnection connection)
        {
            string selectExistingQuery = "SELECT * FROM fmlFP WHERE txtEmaFP = @Email";
            using (SqlCommand cmdSelectExisting = new SqlCommand(selectExistingQuery, connection))
            {
                cmdSelectExisting.Parameters.AddWithValue("@Email", email);

                // Leitor de dados
                using (SqlDataReader readerExisting = cmdSelectExisting.ExecuteReader())
                {
                    if (readerExisting.Read())
                    {
                        AtualizarCamposDoFormulario(readerExisting);
                    }
                } // O leitor de dados é fechado automaticamente aqui
            } // O comando é fechado automaticamente aqui
        }



        private void AtualizarCamposDoFormulario(SqlDataReader reader)
        {
            txtNomeFP.Text = reader["txtNomeFP"].ToString();
            txtSalFP.Text = reader["txtSalFP"].ToString();
            txtAtraso.Text = reader["txtAtraso"].ToString();
            txtFaltas.Text = reader["txtFaltas"].ToString();
            txtAtest.Text = reader["txtAtest"].ToString();
            txtBen.Text = reader["txtBen"].ToString();
            txtINSS.Text = reader["txtINSS"].ToString();
            txtFerias.Text = reader["txtFerias"].ToString();
            txtDT.Text = reader["txtDTS"].ToString();
        }

        private void GerarNovasInformacoes(string email, SqlConnection connection)
        {
            string selectCadQuery = "SELECT txtNome, txtSal FROM fmlCad WHERE txtEmail = @Email";
            using (SqlCommand cmdSelectCad = new SqlCommand(selectCadQuery, connection))
            {
                cmdSelectCad.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader readerCad = cmdSelectCad.ExecuteReader())
                {
                    if (readerCad.Read())
                    {
                        string nome = readerCad["txtNome"].ToString();
                        decimal salario = Convert.ToDecimal(readerCad["txtSal"]);

                        int atraso = GerarValorAleatorio(0, 15);
                        int faltas = GerarValorAleatorio(0, 30);
                        int atest = GerarValorAleatorio(0, 10);
                        int ben = GerarValorAleatorio(1, 5);
                        decimal inss = CalcularINSS(salario);
                        int ferias = GerarValorAleatorio(0, 20);
                        decimal dts = CalcularDecimoTerceiro(salario);

                        string insertQuery = @"
                    INSERT INTO fmlFP (
                        txtnomeFP, txtEmaFP, txtSalFP, txtAtraso, txtFaltas, 
                        txtAtest, txtBen, txtINSS, txtFerias, txtDTS, funcionarioId
                    ) VALUES (
                        @txtNome, @txtEmail, @txtSal, @txtAtraso, @txtFaltas, 
                        @txtAtest, @txtBen, @txtINSS, @txtFerias, @txtDTS, 1
                    )";

                        using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection))
                        {
                            cmdInsert.Parameters.AddWithValue("@txtNome", nome);
                            cmdInsert.Parameters.AddWithValue("@txtEmail", email);
                            cmdInsert.Parameters.AddWithValue("@txtSal", salario);
                            cmdInsert.Parameters.AddWithValue("@txtAtraso", atraso);
                            cmdInsert.Parameters.AddWithValue("@txtFaltas", faltas);
                            cmdInsert.Parameters.AddWithValue("@txtAtest", atest);
                            cmdInsert.Parameters.AddWithValue("@txtBen", ben);
                            cmdInsert.Parameters.AddWithValue("@txtINSS", inss);
                            cmdInsert.Parameters.AddWithValue("@txtFerias", ferias);
                            cmdInsert.Parameters.AddWithValue("@txtDTS", dts);

                            if (connection.State == ConnectionState.Open)
                            {
                                connection.Close();  // Fecha a conexão manualmente apenas se estiver aberta
                            }

                            try
                            {
                                connection.Open();  // Abre a conexão manualmente

                                int linhasAfetadasInsert = cmdInsert.ExecuteNonQuery();

                                if (linhasAfetadasInsert > 0)
                                {
                                    MessageBox.Show("Dados armazenados com sucesso na tabela fmlFP!");

                                    // Buscar os dados recém-inseridos para atualizar o formulário
                                    string selectInsertedDataQuery = "SELECT * FROM fmlFP WHERE txtEmaFP = @Email";
                                    using (SqlCommand cmdSelectInsertedData = new SqlCommand(selectInsertedDataQuery, connection))
                                    {
                                        cmdSelectInsertedData.Parameters.AddWithValue("@Email", email);

                                        using (SqlDataReader readerInsertedData = cmdSelectInsertedData.ExecuteReader())
                                        {
                                            if (readerInsertedData.Read())
                                            {
                                                AtualizarCamposDoFormulario(readerInsertedData);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao armazenar dados na tabela fmlFP.");
                                }
                            }
                            finally
                            {
                                connection.Close();  // Fecha a conexão manualmente
                            }
                        }
                    }
                }
            }
        }

        private void AtualizarCamposDoFormulario(SqlParameterCollection parameters)
        {
            txtNomeFP.Text = parameters["@txtNome"].Value.ToString();
            txtSalFP.Text = parameters["@txtSal"].Value.ToString();
            txtAtraso.Text = parameters["@txtAtraso"].Value.ToString();
            txtFaltas.Text = parameters["@txtFaltas"].Value.ToString();
            txtAtest.Text = parameters["@txtAtest"].Value.ToString();
            txtBen.Text = parameters["@txtBen"].Value.ToString();
            txtINSS.Text = parameters["@txtINSS"].Value.ToString();
            txtFerias.Text = parameters["@txtFerias"].Value.ToString();
            txtDT.Text = parameters["@txtDTS"].Value.ToString();
        }

        private int GerarValorAleatorio(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private decimal CalcularINSS(decimal salario)
        {
            // Lógica de cálculo do INSS (substitua pelo seu código real)
            decimal percentualINSS = 0.1m; // 10% de exemplo
            decimal valorINSS = salario * percentualINSS;

            return valorINSS;
        }

        private decimal CalcularDecimoTerceiro(decimal salario)
        {
            // Lógica de cálculo do décimo terceiro (substitua pelo seu código real)
            decimal valorDecimoTerceiro = salario / 12;

            return valorDecimoTerceiro;
        }


        // Informações geradas
        private void txtNomeFP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFaltas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtINSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalFP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAtest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFerias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAtraso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
