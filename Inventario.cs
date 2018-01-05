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
    public partial class Inventario : Form
    {
       
        public Inventario()
        {
            InitializeComponent();

            string NumInt = Properties.Settings.Default.NumInt;

            lblNameLogin.Text = NumInt;

            string sqlName = "SELECT `nome` FROM `users` WHERE numint = @numint";
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

            Actions.Start();
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

        private void FillEPIUrbano()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                string sqlEpiUrbano = "select `nome` as Equipamento, `tam` as Tamanho from inventario LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tiposfardamento ON equipamento.tipo = tiposfardamento.tipo LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id WHERE equipamento.tipo = 1";

                MySqlCommand sqlCmd = new MySqlCommand(sqlEpiUrbano, conn);

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

                string sqlEPIFlorestal = "select `nome` as Equipamento, `tam` as Tamanho from inventario LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tiposfardamento ON equipamento.tipo = tiposfardamento.tipo LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id WHERE equipamento.tipo = 2";

                MySqlCommand sqlCmd = new MySqlCommand(sqlEPIFlorestal, conn);

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

                string sqlFarda1 = "select `nome` as Equipamento, `tam` as Tamanho from inventario LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tiposfardamento ON equipamento.tipo = tiposfardamento.tipo LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id WHERE equipamento.tipo = 3";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFarda1, conn);

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

                string sqlFarda2 = "select `nome` as Equipamento, `tam` as Tamanho from inventario LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tiposfardamento ON equipamento.tipo = tiposfardamento.tipo LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id WHERE equipamento.tipo = 4";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFarda2, conn);

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

                string sqlFarda3 = "select `nome` as Equipamento, `tam` as Tamanho from inventario LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tiposfardamento ON equipamento.tipo = tiposfardamento.tipo LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id WHERE equipamento.tipo = 5";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFarda3, conn);

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

        private void Actions_Tick(object sender, EventArgs e)
        {
            FillEPIUrbano();
            FillEPIFlorestal();
            FillFarda1();
            FillFarda2();
            FillFarda3();
        }

        public void FillResultados()
        {
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                FindInvent Find = new FindInvent();

                conn.Open();

                string sqlResultados = "select `nome` as Equipamento, `tam` as Tamanho from inventario LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tiposfardamento ON equipamento.tipo = tiposfardamento.tipo LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id WHERE equipamento.tipo = @tipo and inventario.tamanho = @tamanho and equipamento.tipo = @tipo";

                MySqlCommand sqlCmd = new MySqlCommand(sqlResultados, conn);
                //sqlCmd.Parameters.AddWithValue("@equipamento", Find.Equipamento);
                //sqlCmd.Parameters.AddWithValue("@tipo", Find.TipoEquipamento);
                //sqlCmd.Parameters.AddWithValue("@tamanho", Find.Tamanho);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridResultados.DataSource = ds.Tables[0];
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
