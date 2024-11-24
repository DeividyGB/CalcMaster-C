using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.Show();
        }

        private void btnRecPass_Click(object sender, EventArgs e)
        {
            FormRecuperarSenha form = new FormRecuperarSenha();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);

            string query = "SELECT COUNT(*) FROM USUARIO WHERE email = @email AND senha = @senha";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    FormInicial form = new FormInicial();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Cadastro não encontrado.");
                }
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
