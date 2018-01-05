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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text != "")
                if (Database.Database.ValidateLogin(txtNumInt.Text, txtPassword.Text))
                {
                    Properties.Settings.Default.NumInt = txtNumInt.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;

                    Form Init = new Init();

                    Init.Show();

                    Hide();
                }
                else
                {
                    MessageBox.Show("As suas cardenciais estão incorretas.", "Bad login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            Properties.Settings.Default.Save();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }      
}
