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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO CalcMaster.dbo.USUARIO (NOME, EMAIL, CPF, SENHA) VALUES ('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtCPF.Text + "','" + txtSenha.Text + "')", conn);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                MessageBox.Show("Registrado.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
