using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fardamentos
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
            lblDateInit.Text = DateTime.UtcNow.ToString();
            Clock.Start();
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            Form Fardamentos = new Fardamentos();

            Fardamentos.Show();

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Form Inventario = new Inventario();

            Inventario.Show();
        }

        private void Init_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblDateInit.Text = DateTime.UtcNow.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pertende sair?",
                     "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                     MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
