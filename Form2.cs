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
    public partial class frm_SobreSistema : Form
    {
        public frm_SobreSistema(string use)
        {
            InitializeComponent();
            lblUsu.Text = use;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
