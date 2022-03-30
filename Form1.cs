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
    public partial class frm_principal : Form
    {
        
        public frm_principal(string user)
        {
            InitializeComponent();
            lblNome.Text = "Usuário : Flavio Martins";
            lblData.Text = DateTime.Now.ToShortDateString();
            lblNome.Text = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_usuarios usuarios = new frm_usuarios();
            usuarios.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void blocosDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "notepad.exe";
            process1.Start();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "calc.exe";
            process1.Start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void wordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "wordpad.exe";
            process1.Start();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "cmd.exe";
            process1.Start();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "iexplore.exe";
            process1.Start();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SobreSistema f = new frm_SobreSistema(lblNome.Text);
            f.Show();


        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem11.Checked)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_contatos contatos = new frm_contatos();
           
            contatos.MdiParent = this;
           
            contatos.Show();

        }

        private void sistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_SobreSistema f = new frm_SobreSistema(lblNome.Text);
            f.Show();
        }

        private void manualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Users\flavi\OneDrive\Documentos\C#\projetos\Exercício_S\Exercício DSI_2.pdf";
            process1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
