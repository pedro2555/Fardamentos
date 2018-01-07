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
    public partial class Fardamentos : Form
    {
        public int NumMecanografico { get; private set; }

        public Fardamentos()
        {
            InitializeComponent();

            this.AcceptButton = btnFind;

            string sqlName = "SELECT `nome`, `nummec` FROM `users` WHERE numint = @numint";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlName, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Properties.Settings.Default.NumInt);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        string result = (string)sqlCmdRes[0];
                        lblNameLogin.Text = result;
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

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            var Atribuir = new Atribuir();

            Atribuir.Bombeiro(NumMecanografico);

            Atribuir.Show();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            var Devolucao = new Devolucao();



            Devolucao.Show();
        }

        public void btnFind_Click(object sender, EventArgs e)
        {

            string sqlName = "SELECT `nome`, `nummec`, `postos`.`posto` FROM `users` LEFT JOIN postos ON users.posto = postos.id WHERE numint = @numint";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlName, conn);
                sqlCmd.Parameters.AddWithValue("@numint", txtFind.Text);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        string nome = (string)sqlCmdRes[0];
                        int numMec = (int)sqlCmdRes[1];
                        string posto = (string)sqlCmdRes[2];

                        lblNomeBomb.Text = nome;
                        lblNumMecBomb.Text = numMec.ToString();
                        lblCatBomb.Text = posto;

                        NumMecanografico = numMec;
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

            FillEPIUrbano();
            FillEPIFlorestal();
            FillFarda1();
            FillFarda2();
            FillFarda3();

        }

        private void FillEPIUrbano()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string sqlEpiUrbano = "SELECT `inventario`.`id` AS Referencia, `equipamento`.`nome` as Equipamento, `tamanhos`.`tam` as Tamanho, `condicoes`.`condicao` as `Condição`, `inventario`.`obs` as Observações, `responsavel_atribuicao` as `Resp. Atribuição`, `data_atribuicao` as `Data Atribuição` FROM atribuicao LEFT JOIN inventario ON atribuicao.equipamento = inventario.id LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id LEFT JOIN condicoes ON inventario.condicao = condicoes.id WHERE bombeiro = @numint and equipamento.tipo = 1";

                MySqlCommand sqlCmd = new MySqlCommand(sqlEpiUrbano, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Convert.ToInt32(txtFind.Text));

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridEPIUrbano.DataSource = ds.Tables[0];
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

        private void FillEPIFlorestal()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string sqlEPIFlorestal = "SELECT `inventario`.`id` AS Referencia, `equipamento`.`nome` as Equipamento, `tamanhos`.`tam` as Tamanho, `condicoes`.`condicao` as `Condição`, `inventario`.`obs` as Observações, `responsavel_atribuicao` as `Resp. Atribuição`, `data_atribuicao` as `Data Atribuição` FROM atribuicao LEFT JOIN inventario ON atribuicao.equipamento = inventario.id LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id LEFT JOIN condicoes ON inventario.condicao = condicoes.id WHERE bombeiro = @numint and equipamento.tipo = 2";

                MySqlCommand sqlCmd = new MySqlCommand(sqlEPIFlorestal, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Convert.ToInt32(txtFind.Text));

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridEPIFlorestal.DataSource = ds.Tables[0];
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

        private void FillFarda1()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string sqlFarda1 = "SELECT `inventario`.`id` AS Referencia, `equipamento`.`nome` as Equipamento, `tamanhos`.`tam` as Tamanho, `condicoes`.`condicao` as `Condição`, `inventario`.`obs` as Observações, `responsavel_atribuicao` as `Resp. Atribuição`, `data_atribuicao` as `Data Atribuição` FROM atribuicao LEFT JOIN inventario ON atribuicao.equipamento = inventario.id LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id LEFT JOIN condicoes ON inventario.condicao = condicoes.id WHERE bombeiro = @numint and equipamento.tipo = 3";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFarda1, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Convert.ToInt32(txtFind.Text));

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridFarda1.DataSource = ds.Tables[0];
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

        private void FillFarda2()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string sqlFarda2 = "SELECT `inventario`.`id` AS Referencia, `equipamento`.`nome` as Equipamento, `tamanhos`.`tam` as Tamanho, `condicoes`.`condicao` as `Condição`, `inventario`.`obs` as Observações, `responsavel_atribuicao` as `Resp. Atribuição`, `data_atribuicao` as `Data Atribuição` FROM atribuicao LEFT JOIN inventario ON atribuicao.equipamento = inventario.id LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id LEFT JOIN condicoes ON inventario.condicao = condicoes.id WHERE bombeiro = @numint and equipamento.tipo = 4";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFarda2, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Convert.ToInt32(txtFind.Text));

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridFarda2.DataSource = ds.Tables[0];
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

        private void FillFarda3()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string sqlFarda3 = "SELECT `inventario`.`id` AS Referencia, `equipamento`.`nome` as Equipamento, `tamanhos`.`tam` as Tamanho, `condicoes`.`condicao` as `Condição`, `inventario`.`obs` as Observações, `responsavel_atribuicao` as `Resp. Atribuição`, `data_atribuicao` as `Data Atribuição` FROM atribuicao LEFT JOIN inventario ON atribuicao.equipamento = inventario.id LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id LEFT JOIN condicoes ON inventario.condicao = condicoes.id WHERE bombeiro = @numint and equipamento.tipo = 5";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFarda3, conn);
                sqlCmd.Parameters.AddWithValue("@numint", Convert.ToInt32(txtFind.Text));

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridFarda3.DataSource = ds.Tables[0];
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
