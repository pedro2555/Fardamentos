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
    }
}
