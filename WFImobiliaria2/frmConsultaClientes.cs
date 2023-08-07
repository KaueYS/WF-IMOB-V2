using DAO;
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
    public partial class frmConsultaClientes : Form
    {

        tb_cadastro cadastroAtual = new tb_cadastro();
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {

            ClienteImovelMetodos objDAO = new ClienteImovelMetodos();
            List<tb_cadastro> listacadastros = objDAO.ConsultarClientes();
            grdConsultaTodos.DataSource = listacadastros;

            grdConsultaTodos.Columns["Id"].Visible = false;


            grdConsultaTodos.Columns["ImovelVendendo"].HeaderText = "Imovel";
            grdConsultaTodos.Columns["ImovelComprando"].HeaderText = "Interesse";
            grdConsultaTodos.Columns["DataCadastro"].HeaderText = "Criado";


        }

        
        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        

       

        private void grdConsultaTodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdConsultaTodos.RowCount >= 0)
            {
                cadastroAtual = grdConsultaTodos.CurrentRow.DataBoundItem as tb_cadastro;
            }
        }

        

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            banco banco = new banco();
            tb_cadastro encontrarId = banco.tb_cadastro.FirstOrDefault(x => x.Id == cadastroAtual.Id);
            MessageBox.Show("Deseja Excluir o cadastro selecionado?", "ATENCAO", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            banco.tb_cadastro.Remove(encontrarId);
            banco.SaveChanges();

            CarregarGrid();
        }
    }
}
