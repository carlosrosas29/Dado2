using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ldado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMuestra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Dado m = new Dado();
            txtMuestra.Text += m.Lanzar();
        }

        private void btnLanzar2_Click(object sender, EventArgs e)
        {
            Dado m = new Dado();
            txtMuestra.Text += m.Suma();
        }

        private void btn2Dados_Click(object sender, EventArgs e)
        {
            Dado DosDados = new Dado();
            txtMuestra.Text += DosDados.Suma();
        }
    }
}

