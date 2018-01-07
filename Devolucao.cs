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
    public partial class Devolucao : Form
    {
        public Devolucao()
        {
            InitializeComponent();
            Responsaveis();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            if (lblBombNumInt.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

                try
                {
                    conn.Open();
                    string sqlDevolverFardamento = "UPDATE inventario SET condicao=@Condicao, disponivel = 1 WHERE id=@Referencia";
                    MySqlCommand sqlCmd = new MySqlCommand(sqlDevolverFardamento, conn);

                    sqlCmd.Parameters.AddWithValue("@Condicao", cboxCondicao.SelectedValue);
                    sqlCmd.Parameters.AddWithValue("@Referencia", txtReference.Text);

                    sqlCmd.ExecuteNonQuery();

                    conn.Close();

                    conn.Open();
                    string sqlDevolverFardamento1 = "UPDATE atribuicao SET responsavel_devolucao=@RespDev, motivo = @Motivo, data_devolucao = NOW() WHERE equipamento=@Referencia1";
                    MySqlCommand sqlCmd1 = new MySqlCommand(sqlDevolverFardamento1, conn);

                    sqlCmd1.Parameters.AddWithValue("@RespDev", Properties.Settings.Default.NumInt);
                    sqlCmd1.Parameters.AddWithValue("@Motivo", txtMotivo.Text);
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

        private void txtReference_TextChanged(object sender, EventArgs e)
        {
            string sqlInsertEquip = "SELECT `tiposfardamento`.`tipo`, `equipamento`.`nome`, `data_atribuicao`, `tamanhos`.`tam` , `users`.`numint` , `users`.`nome`, `inventario`.`condicao`, `condicoes`.`condicao`, `responsavel_atribuicao`, `data_devolucao` FROM `atribuicao` LEFT JOIN inventario ON atribuicao.equipamento = inventario.id LEFT JOIN equipamento ON inventario.equipamento = equipamento.id LEFT JOIN tiposfardamento ON equipamento.tipo = tiposfardamento.id LEFT JOIN tamanhos ON inventario.tamanho = tamanhos.id LEFT JOIN users ON atribuicao.bombeiro = users.numint LEFT JOIN condicoes ON inventario.condicao = condicoes.id WHERE inventario.id = @equipamento and data_devolucao is null";
            MySqlConnection conn = new MySqlConnection(Database.Database.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlInsertEquip, conn);
                sqlCmd.Parameters.AddWithValue("@equipamento", txtReference.Text);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                {
                    while (sqlCmdRes.Read())
                    {
                        string tiposequipamento = (string)sqlCmdRes[0];
                        string equipamento = (string)sqlCmdRes[1];
                        DateTime dataentrega = (DateTime)sqlCmdRes[2];
                        string tamanhos = (string)sqlCmdRes[3];
                        int numint = (int)sqlCmdRes[4];
                        string nomebomb = (string)sqlCmdRes[5];
                        string condicaoText = (string)sqlCmdRes[7];
                        int respAtribuicao = (int)sqlCmdRes[8];

                        txtTiposEquipamento.Text = tiposequipamento;
                        txtEquipamento.Text = equipamento;
                        lblDataentrega.Text = String.Format("{0:MM-dd-yyyy}", dataentrega);
                        txtTamanhos.Text = tamanhos;
                        lblBombNome.Text = nomebomb;
                        lblBombNumInt.Text = numint.ToString();
                        txtCondicaoEntrega.Text = condicaoText;
                        lblRespAtribuicao.Text = respAtribuicao.ToString();

                    }
                }
                else
                {
                    txtTiposEquipamento.Text = null;
                    txtEquipamento.Text = null;
                    lblDataentrega.Text = null;
                    txtTamanhos.Text = null;
                    lblBombNome.Text = null;
                    lblBombNumInt.Text = null;
                    txtCondicaoEntrega.Text = null;
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
                conn.Open();

                string sqlEquipamento = "SELECT `condicoes`.`condicao`, `condicoes`.`id` FROM `condicoes` LEFT JOIN inventario ON condicoes.id = inventario.condicao";

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlEquipamento, conn);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd1);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxCondicao.DataSource = ds.Tables[0];
                cboxCondicao.ValueMember = "id";
                cboxCondicao.DisplayMember = "condicao";

                conn.Close();
            }
        }
    }
}
