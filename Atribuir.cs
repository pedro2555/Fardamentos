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
    public partial class Atribuir : Form
    {
        public Atribuir()
        {
            Fardamentos f = new Fardamentos();

            InitializeComponent();
            Equipamento();
            Responsaveis();
            TipoEquipamento();

        }

        private void Atribuir_Click(object sender, EventArgs e)
        {
            if (lblBombNumInt.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

                try
                {
                    conn.Open();
                    string sqlInserirFardamento = "INSERT INTO `atribuicao` ( `equipamento` , `bombeiro`, `data_atribuicao`, `responsavel_atribuicao`, `obs`) VALUES(@equipamento, @bombeiro, NOW(), @responsavel, @obs)";
                    MySqlCommand sqlCmd = new MySqlCommand(sqlInserirFardamento, conn);

                    sqlCmd.Parameters.AddWithValue("@equipamento", cboxEquipamento.SelectedValue);
                    sqlCmd.Parameters.AddWithValue("@bombeiro", lblBombNumInt.Text);
                    sqlCmd.Parameters.AddWithValue("@responsavel", lblRespNumInt.Text);
                    sqlCmd.Parameters.AddWithValue("@obs", txtObs.Text);
                    sqlCmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    string sqlInserirFardamento1 = "UPDATE inventario SET disponivel = 0 WHERE id=@Referencia1";
                    MySqlCommand sqlCmd1 = new MySqlCommand(sqlInserirFardamento1, conn);

                    sqlCmd1.Parameters.AddWithValue("@Referencia1", txtReference.Text);

                    sqlCmd1.ExecuteNonQuery();

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
            else
            {
                MessageBox.Show("Insira um bombeiro para poder atribuir material.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Responsaveis()
        {

            string NumInt = Properties.Settings.Default.NumInt;

            lblRespNumInt.Text = NumInt;

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
                        lblRespNome.Text = result;
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

        public void Bombeiro(int NumMec)
        {

            string sqlInsertEquip = "SELECT `nome`, `numint` FROM `users` WHERE nummec = @nummec";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlInsertEquip, conn);
                sqlCmd.Parameters.AddWithValue("@nummec", NumMec);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        string nome = (string)sqlCmdRes[0];
                        int numint = (int)sqlCmdRes[1];

                        if (NumMec != 0) {
                            lblBombNome.Text = nome;
                            lblBombNumInt.Text = numint.ToString();
                        }
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

                string sqlEquipamento = "SELECT `inventario`.`id` as Reference, `nome` FROM inventario LEFT JOIN equipamento ON inventario.equipamento = equipamento.id WHERE tipo = @tipo ORDER by inventario.dataentrada asc";

                MySqlCommand sqlCmd = new MySqlCommand(sqlEquipamento, conn);
                sqlCmd.Parameters.AddWithValue("@tipo", cboxTipoEquipamento.SelectedValue);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxEquipamento.DataSource = ds.Tables[0];
                cboxEquipamento.ValueMember = "Reference";
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
            string sqlName = "SELECT `tam` FROM `tamanhos` LEFT JOIN inventario ON tamanhos.id = inventario.tamanho WHERE inventario.id = @id";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlName, conn);
                sqlCmd.Parameters.AddWithValue("@id", txtReference.Text);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        string tamanho = (string)sqlCmdRes[0];

                        txtTamanhos.Text = tamanho;

                    }

            }
            catch (Exception crap)
            {
                // pass the exception to the caller with an usefull message
                throw new Exception(String.Format("Failed to load flight plan for user {0}.\r\nSQL Statements: {1}", Properties.Settings.Default.NumInt, sqlName), crap);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Condicao()
        {
            string sqlName = "SELECT `condicoes`.`condicao` FROM `condicoes` LEFT JOIN inventario ON condicoes.id = inventario.condicao WHERE inventario.id = @id";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlName, conn);
                sqlCmd.Parameters.AddWithValue("@id", txtReference.Text);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        string condicao = (string)sqlCmdRes[0];

                        txtCondicao.Text = condicao;

                    }

            }
            catch (Exception crap)
            {
                // pass the exception to the caller with an usefull message
                throw new Exception(String.Format("Failed to load flight plan for user {0}.\r\nSQL Statements: {1}", Properties.Settings.Default.NumInt, sqlName), crap);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cboxTipoEquipamento_SelectedValueChanged(object sender, EventArgs e)
        {
            Equipamento();            
        }

        private void cboxEquipamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboxEquipamento.SelectedValue != null)
            {
                txtReference.Text = cboxEquipamento.SelectedValue.ToString();
            }
            Tamanhos();
            Condicao();
        }
    }

}
