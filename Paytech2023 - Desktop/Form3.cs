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
using Paytech2023.PAYTECH_OFICIALDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paytech2023
{
    public partial class fmlCad : Form
    {
        public fmlCad()
        {
            InitializeComponent();
        }

        private void btnVoltarc_Click(object sender, EventArgs e)
        {
            fmlHome telaHome = new fmlHome();

            telaHome.Show();

            this.Hide();
        }

        //Preenchimento do cadastro Dados Pessoais
        private void txtNomec_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {

        }
        //Preenchimento do Cadastro Dados Residenciais
        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCom_TextChanged(object sender, EventArgs e)
        {

        }
        // Salva o Cadastro
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-ND0O9QK\SQLEXPRESSTESTE; integrated security=SSPI;initial catalog=PAYTECH_OFICIAL"; // Substitua pela sua string de conexão real

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Inicia a transação
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Comando SQL com uma instrução INSERT para ambas as tabelas
                    string insertQuery1 = @"
                INSERT INTO fmlCad (
                    txtNome, txtCPF, txtRG, txtEmail, txtGen, 
                    txtData, txtTel, txtEC, txtCargo, txtSal, 
                    txtEnd, txtNum, txtComplemento, txtBairro, 
                    txtCid, txtEstado, txtCEP, loginID 
                ) VALUES (
                    @txtNome, @txtCPF, @txtRG, @txtEmail, @txtGen, 
                    CONVERT(DATE, @txtData, 103), @txtTel, @txtEC, @txtCargo, @txtSal, 
                    @txtEnd, @txtNum, @txtComplemento, @txtBairro, 
                    @txtCid, @txtEstado, @txtCEP, 1
                )";

                    using (SqlCommand cmd1 = new SqlCommand(insertQuery1, connection, transaction))
                    {
                        // Adicionar parâmetros
                        cmd1.Parameters.AddWithValue("@txtNome", txtNomec.Text);
                        cmd1.Parameters.AddWithValue("@txtCPF", txtCPF.Text);
                        cmd1.Parameters.AddWithValue("@txtRG", txtRG.Text);
                        cmd1.Parameters.AddWithValue("@txtEmail", txtEmail.Text);
                        cmd1.Parameters.AddWithValue("@txtGen", txtGen.Text);
                        cmd1.Parameters.AddWithValue("@txtData", txtData.Text);
                        cmd1.Parameters.AddWithValue("@txtTel", txtTel.Text);
                        cmd1.Parameters.AddWithValue("@txtEC", txtEC.Text);
                        cmd1.Parameters.AddWithValue("@txtCargo", txtCargo.Text);
                        cmd1.Parameters.AddWithValue("@txtSal", txtSal.Text);
                        cmd1.Parameters.AddWithValue("@txtEnd", txtEnd.Text);
                        cmd1.Parameters.AddWithValue("@txtNum", txtNum.Text);
                        cmd1.Parameters.AddWithValue("@txtComplemento", txtCom.Text);
                        cmd1.Parameters.AddWithValue("@txtBairro", txtBairro.Text);
                        cmd1.Parameters.AddWithValue("@txtCid", txtCid.Text);
                        cmd1.Parameters.AddWithValue("@txtEstado", txtEstado.Text);
                        cmd1.Parameters.AddWithValue("@txtCEP", txtCEP.Text);

                        // Executar a consulta
                        int linhasAfetadas1 = cmd1.ExecuteNonQuery();

                        // Verificar se a primeira consulta foi bem-sucedida
                        if (linhasAfetadas1 <= 0)
                        {
                            throw new Exception("Erro ao salvar o cadastro.");
                        }
                    }

                    // Comando SQL para a segunda instrução INSERT
                    string insertQuery2 = @"
                INSERT INTO fmlLogin (
                    txtLogin, txtSenha
                ) VALUES (
                    @txtEmail, @txtCPF
                )";

                    using (SqlCommand cmd2 = new SqlCommand(insertQuery2, connection, transaction))
                    {
                        // Adicionar parâmetros
                        cmd2.Parameters.AddWithValue("@txtEmail", txtEmail.Text);
                        cmd2.Parameters.AddWithValue("@txtCPF", txtCPF.Text);

                        // Executar a segunda consulta
                        int linhasAfetadas2 = cmd2.ExecuteNonQuery();

                        // Verificar se a segunda consulta foi bem-sucedida
                        if (linhasAfetadas2 <= 0)
                        {
                            throw new Exception("Erro ao salvar o cadastro.");
                        }
                    }

                    // Commit da transação se tudo estiver bem
                    transaction.Commit();
                    MessageBox.Show("Cadastro salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    // Rollback da transação em caso de erro
                    transaction.Rollback();
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }











        private void fmlCad_Load(object sender, EventArgs e)
        {
        }
    }
}
