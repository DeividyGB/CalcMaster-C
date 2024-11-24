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

namespace CalcMaster
{
    public partial class FormHistorico : Form
    {
        public FormHistorico()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=SKULLIUS\\SQLEXPRESS;Initial Catalog=CalcMaster;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT N1, OP, N2, R1, R2 FROM HISTORICO", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                gridHist.DataSource = ds;
                gridHist.DataMember = ds.Tables[0].TableName;
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
