using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_S
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Antonio" && txtSenha.Text == "Toni123")
            {
                frm_principal seguir = new frm_principal(txtUsuario.Text);
                seguir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login ou senha incorreto");
                txtUsuario.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtUsuario.Focus();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
