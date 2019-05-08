using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDV pdv = new PDV();
            Principal.ActiveForm.Hide();
            pdv.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque est = new Estoque();
            Principal.ActiveForm.Hide();
            est.ShowDialog();

        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            Principal.ActiveForm.Hide();
            cal.ShowDialog();
        }
    }
}
