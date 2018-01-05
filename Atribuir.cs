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

            Responsaveis();
        }

        private void Atribuir_Click(object sender, EventArgs e)
        {
            Hide();
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
                        string numint = (string)sqlCmdRes[1];

                        lblBombNome.Text = nome;
                        lblBombNumInt.Text = numint;
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
    }

}
