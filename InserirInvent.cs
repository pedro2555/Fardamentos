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
            Equipamento();
            Tamanhos();
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();
                string sqlInserirFardamento = "INSERT INTO `inventario` ( `tipo` , `equipamento` , `tamanho`) VALUES(@tipo, @equipamento, @tamanho)";
                MySqlCommand sqlCmd = new MySqlCommand(sqlInserirFardamento, conn);

                sqlCmd.Parameters.AddWithValue("@tipo", cboxTipoEquipamento.SelectedItem);
                sqlCmd.Parameters.AddWithValue("@equipamento", cboxEquipamento.SelectedItem);
                sqlCmd.Parameters.AddWithValue("@tamanho", cboxTamanhos.SelectedItem);
                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                Hide();
            }
        }

        public void Responsaveis()
        {

            string NumInt = Properties.Settings.Default.NumInt;

            lblNumInt.Text = NumInt;

            string result = null;
            string sqlStrGetFlight = "SELECT `nome` FROM `users WHERE numint = @numint";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);
            
            try
            {
                conn.Open();

                
                // GET FLIGHT DATA
                MySqlCommand sqlCmd = new MySqlCommand(sqlStrGetFlight, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Properties.Settings.Default.NumInt);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result = (string)sqlCmdRes[0];
                        lblNameResp.Text = result;
                    }
                else
                    result = null;
            }
            catch (Exception crap)
            {
                result = null;
                // pass the exception to the caller with an usefull message
                throw new Exception(String.Format("Failed to load flight plan for user {0}.\r\nSQL Statements: {1}", Properties.Settings.Default.NumInt, sqlStrGetFlight), crap);
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

                string sqlTipoEquipamento = "SELECT `id`, `tipo` FROM tiposfardamento";

                MySqlCommand sqlCmd = new MySqlCommand(sqlTipoEquipamento, conn);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxEquipamento.DataSource = ds.Tables[0];
                cboxEquipamento.ValueMember = "id";
                cboxEquipamento.DisplayMember = "tipo";
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

        public void Equipamento()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string query = "SELECT `id`, `nome` FROM equipamento";
                MySqlCommand cmd;

                cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("tamanhos");
                da.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        cboxEquipamento.Items.Add(row.ItemArray[1].ToString());

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

        public void Tamanhos()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string query = "SELECT `id`, `tam` FROM tamanhos";
                MySqlCommand cmd;

                cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("tamanhos");
                da.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        cboxTamanhos.Items.Add(row.ItemArray[1].ToString());

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
