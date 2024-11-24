using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class FormRecuperarSenha : Form
    {
        public FormRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strCon);

            string queryNome = "SELECT nome FROM USUARIO WHERE cpf = @cpf";
            string queryEmail = "SELECT email FROM USUARIO WHERE cpf = @cpf";
            string querySenha = "SELECT senha FROM USUARIO WHERE cpf = @cpf";

            SqlCommand nomeCmd = new SqlCommand(queryNome, conn);
            SqlCommand emailCmd = new SqlCommand(queryEmail, conn);
            SqlCommand senhaCmd = new SqlCommand(querySenha, conn);

            nomeCmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            emailCmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            senhaCmd.Parameters.AddWithValue("@cpf", txtCPF.Text);

            try
            {
                conn.Open();

                txtNome.Text = nomeCmd.ExecuteScalar()?.ToString();
                txtEmail.Text = emailCmd.ExecuteScalar()?.ToString();
                txtSenha.Text = senhaCmd.ExecuteScalar()?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
