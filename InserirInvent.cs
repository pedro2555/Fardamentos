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
            int copies = 0; 

            if (Convert.ToInt32(txtQuantidade.Text) >= 1) 
                copies = Convert.ToInt32(txtQuantidade.Text) - 1;           
            else           
                MessageBox.Show("Insira a Quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            int i;

            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();
                string sqlInserirFardamento = "INSERT INTO `inventario` ( `equipamento` , `tamanho`, `obs`, `responsavel`, `dataentrada`) VALUES(@equipamento, @tamanho, @obs, @responsavel, NOW())";
                MySqlCommand sqlCmd = new MySqlCommand(sqlInserirFardamento, conn);

                sqlCmd.Parameters.AddWithValue("@equipamento", cboxEquipamento.SelectedValue);
                sqlCmd.Parameters.AddWithValue("@tamanho", cboxTamanhos.SelectedValue);
                sqlCmd.Parameters.AddWithValue("@obs", txtObs.Text);
                sqlCmd.Parameters.AddWithValue("@responsavel", lblNumInt.Text);

                for (i = 0; i <= copies; i++)
                {
                    sqlCmd.ExecuteNonQuery();
                }
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

            string sqlInsertEquip = "SELECT `nome` FROM `users` WHERE numint = @numint";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);
            
            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlInsertEquip, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Properties.Settings.Default.NumInt);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        string result = (string)sqlCmdRes[0];
                        lblNameResp.Text = result;
                    }

            }
            catch (Exception crap)
            {
                // pass the exception to the caller with an usefull message
                throw new Exception(String.Format("Failed to load flight plan for user {0}.\r\nSQL Statements: {1}", Properties.Settings.Default.NumInt, sqlInsertEquip), crap);
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
                cboxTipoEquipamento.DataSource = ds.Tables[0];
                cboxTipoEquipamento.ValueMember = "id";
                cboxTipoEquipamento.DisplayMember = "tipo";
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

                string sqlEquipamento = "SELECT `id`, `nome` FROM equipamento WHERE tipo = @tipo";

                MySqlCommand sqlCmd = new MySqlCommand(sqlEquipamento, conn);
                sqlCmd.Parameters.AddWithValue("@tipo", cboxTipoEquipamento.SelectedValue);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxEquipamento.DataSource = ds.Tables[0];
                cboxEquipamento.ValueMember = "id";
                cboxEquipamento.DisplayMember = "nome";
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

                string sqlTamanhos = "SELECT `id`, `tam` FROM tamanhos";

                MySqlCommand sqlCmd = new MySqlCommand(sqlTamanhos, conn);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxTamanhos.DataSource = ds.Tables[0];
                cboxTamanhos.ValueMember = "id";
                cboxTamanhos.DisplayMember = "tam";
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


        private void cboxTipoEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipamento();
        }
    }
}
