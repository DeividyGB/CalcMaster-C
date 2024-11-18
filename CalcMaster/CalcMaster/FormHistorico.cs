using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalcMaster
{
    public partial class FormHistorico : Form
    {
        public FormHistorico()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 * valor2;

            txtResul.Text = $"{resultado}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 + valor2;

            txtResul.Text = $"{resultado}";
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 - valor2;

            txtResul.Text = $"{resultado}";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);

            double resultado = valor1 * valor1;

            txtResul.Text = $"{resultado}";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);
            double valor2 = Convert.ToDouble(txtNum2.Text);

            double resultado = valor1 / valor2;

            txtResul.Text = $"{resultado}";
        }

        private void btnRaizSquare_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNum1.Text);

            double resultado = Math.Sqrt(valor1);

            txtResul.Text = $"{resultado}";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResul.Text = "";
        }
    }
}
