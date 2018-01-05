using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Fardamentos
{
    public partial class InserirInvent : Form
    {
        public InserirInvent()
        {
            InitializeComponent();
            Responsaveis();
            TipoEquipamento();
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void Responsaveis()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string query = "SELECT `numint`, `nome` FROM users WHERE responsavel = 1";
                MySqlCommand cmd;

                cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("users");
                da.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        cboxResponsavel.Items.Add(row.ItemArray[1].ToString());

                    }
                }

            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void TipoEquipamento()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string query = "SELECT `id`, `tipo` FROM tiposfardamento";
                MySqlCommand cmd;

                cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("tiposfardamento");
                da.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        cboxTipoEquipamento.Items.Add(row.ItemArray[1].ToString());

                    }
                }

            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
