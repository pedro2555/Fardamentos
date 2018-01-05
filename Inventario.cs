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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            Form InserirInvent = new InserirInvent();

            InserirInvent.Show();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form FindInvent = new FindInvent();

            FindInvent.Show();
        }
    }
}
