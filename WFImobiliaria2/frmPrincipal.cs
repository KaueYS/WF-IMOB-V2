using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFImobiliaria2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes cliente = new frmConsultaClientes();
            cliente.ShowDialog();
        }

        private void possiveisCompradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPossiveisCompradores compradores = new frmPossiveisCompradores();
            compradores.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
