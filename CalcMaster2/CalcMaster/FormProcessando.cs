using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class FormProcessando : Form
    {
        private Timer tempo;
        public FormProcessando()
        {
            InitializeComponent();

            tempo = new Timer();
            tempo.Interval = 1;
            tempo.Tick += Timer_Tick;
            tempo.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            tempo.Stop();
        }

        public static void ShowMessage(string message)
        {
            FormProcessando form = new FormProcessando();
            form.ShowDialog(); 
        }
    }
}
