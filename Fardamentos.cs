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
    public partial class Fardamentos : Form
    {
        public Fardamentos()
        {
            InitializeComponent();

            this.AcceptButton = btnFind;
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            Form Atribuir = new Atribuir();

            Atribuir.Show();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            Form Devolucao = new Devolucao();

            Devolucao.Show();
        }
    }
}
