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

    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 + valor2;

            txtResul.Text = $"{resultado}";
            txtResul2.Text = "";

            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO CalcMaster.dbo.HISTORICO (N1, N2, OP, R1) VALUES (" + valor1 + "," + valor2 + ", '+', " + resultado + ")", conn);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                FormProcessando form = new FormProcessando();
                form.Show();
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

        private void btnSubt_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 - valor2;

            txtResul.Text = $"{resultado}";
            txtResul2.Text = "";

            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO CalcMaster.dbo.HISTORICO (N1, N2, OP, R1) VALUES (" + valor1 + "," + valor2 + ", '-', " + resultado + ")", conn);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                FormProcessando form = new FormProcessando();
                form.Show();
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

        private void btnMult_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 * valor2;

            txtResul.Text = $"{resultado}";
            txtResul2.Text = "";

            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO CalcMaster.dbo.HISTORICO (N1, N2, OP, R1) VALUES (" + valor1 + "," + valor2 + ", '*', " + resultado + ")", conn);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                FormProcessando form = new FormProcessando();
                form.Show();
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

        private void btnDivi_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = Math.Round(valor1 / valor2, 2);

            txtResul.Text = $"{resultado}";
            txtResul2.Text = "";

            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO CalcMaster.dbo.HISTORICO (N1, N2, OP, R1) VALUES (" + valor1 + "," + valor2 + ", '/', " + txtResul.Text.Replace(",", ".") + ")", conn);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                FormProcessando form = new FormProcessando();
                form.Show();
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

        private void btnPow2_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 * valor1;
            double resultado2 = valor2 * valor2;

            txtResul.Text = $"{resultado}";
            txtResul2.Text = $"{resultado2}";

            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO CalcMaster.dbo.HISTORICO (N1, N2, OP, R1, R2) VALUES (" + valor1 + "," + valor2 + ", 'X²', " + txtResul.Text.Replace(",", ".") + "," + txtResul2.Text.Replace(", ", ".") + ")", conn);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                FormProcessando form = new FormProcessando();
                form.Show();
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

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = Math.Round(Math.Sqrt(valor1), 2);
            double resultado2 = Math.Round(Math.Sqrt(valor2), 2);

            txtResul.Text = $"{resultado}";
            txtResul2.Text = $"{resultado2}";

            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO CalcMaster.dbo.HISTORICO (N1, N2, OP, R1, R2) VALUES (" + valor1 + "," + valor2 + ", '²√', " + txtResul.Text.Replace(",", ".") + "," + txtResul2.Text.Replace(", ", ".") + ")", conn);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                FormProcessando form = new FormProcessando();
                form.Show();
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResul.Text = "";
            txtResul2.Text = "";
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            FormHistorico form = new FormHistorico();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
