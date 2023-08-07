using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFImobiliaria2
{
    public partial class frmCadastro : Form
    {


        public frmCadastro()
        {
            InitializeComponent();
        }


        //EVENTOS ==========================================================================================================

        private void grdCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCadastro.RowCount > 0)
            {

                tb_cadastro cadastroAtual = grdCadastro.CurrentRow.DataBoundItem as tb_cadastro;

                txtNomeDoCliente.Text = cadastroAtual.Nome;
                txtEmail.Text = cadastroAtual.Email;
                mskCelular.Text = cadastroAtual.Celular;
                txtNomeImovelVendendo.Text = cadastroAtual.ImovelVendendo;
                txtValorPedido.Text = Convert.ToString(cadastroAtual.Valor);
                txtNomeDoImovelCompra.Text = cadastroAtual.ImovelComprando;
                dtCadastro.Value = cadastroAtual.DataCadastro;
                txtObeservacoes.Text = cadastroAtual.Observacoes;
                ControlarTela(2);
            }

        }



        private void frmCadastro_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ControlarTela(1);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ControlarTela(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_cadastro cadastroAtual = grdCadastro.CurrentRow.DataBoundItem as tb_cadastro;
            banco banco = new banco();
            tb_cadastro encontrarId = banco.tb_cadastro.FirstOrDefault(x => x.Id == cadastroAtual.Id);
            
            banco.tb_cadastro.Remove(encontrarId);
            banco.SaveChanges();
            CarregarGrid();
            LimparCampos();
            ControlarTela(1);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
                
            if (ValidarCampos())
            {
                
                tb_cadastro cadastro = new tb_cadastro();
                ClienteImovelMetodos objDAO = new ClienteImovelMetodos();
                

                cadastro.Nome = txtNomeDoCliente.Text;
                cadastro.Email = txtEmail.Text;
                cadastro.Celular = mskCelular.Text;
                cadastro.ImovelVendendo = txtNomeImovelVendendo.Text;
                cadastro.Valor = Convert.ToDecimal(txtValorPedido.Text);
                cadastro.ImovelComprando = txtNomeDoImovelCompra.Text;
                cadastro.DataCadastro = dtCadastro.Value.Date;
                cadastro.Observacoes = txtObeservacoes.Text;

                try
                {
                    objDAO.Alterar(cadastro);


                    CarregarGrid();
                    LimparCampos();
                    ControlarTela(1);
                    MessageBox.Show("Cliente Alterado com sucesso - PRECISA DELETAR O CADASTRO ANTERIOR", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel Alterar o atendimento", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                tb_cadastro obj = new tb_cadastro();
                ClienteImovelMetodos objDAO = new ClienteImovelMetodos();


                obj.Nome = txtNomeDoCliente.Text.Trim().ToUpper();
                obj.Email = txtEmail.Text.Trim().ToLower();
                obj.Celular = mskCelular.Text;
                obj.ImovelVendendo = txtNomeImovelVendendo.Text.ToUpper().Trim();
                obj.Valor = Convert.ToDecimal(txtValorPedido.Text, System.Globalization.CultureInfo.InvariantCulture);
                obj.ImovelComprando = txtNomeDoImovelCompra.Text.ToUpper().Trim();
                obj.DataCadastro = Convert.ToDateTime(dtCadastro.Value);
                obj.Observacoes = txtObeservacoes.Text;

                try
                {
                    objDAO.CadastrarDAO(obj);
                    LimparCampos();
                    CarregarGrid();
                    MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                
            }
        }

        //METODOS =================================================================================================================

        private void LimparCampos()
        {
            txtNomeDoCliente.Clear();
            txtEmail.Clear();
            mskCelular.Clear();
            txtNomeImovelVendendo.Clear();
            txtNomeDoImovelCompra.Clear();
            txtValorPedido.Clear();
            txtObeservacoes.Clear();
            dtCadastro.Value = DateTime.Now;
        }

        private void CarregarGrid()
        {

            ClienteImovelMetodos objDAO = new ClienteImovelMetodos();
            List<tb_cadastro> listacadastros = objDAO.ConsultarClientes();
            grdCadastro.DataSource = listacadastros;

            grdCadastro.Columns["Id"].Visible = false;

            grdCadastro.Columns["ImovelVendendo"].HeaderText = "Imovel";
            grdCadastro.Columns["ImovelComprando"].HeaderText = "Interesse";
            grdCadastro.Columns["DataCadastro"].HeaderText = "Criado";

        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNomeDoCliente.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome Completo \n";
            }
            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += "- Email \n ";
            }
            if (mskCelular.Text == "")
            {
                ret = false;
                campos += "- Telefone \n ";
            }
            if (txtNomeImovelVendendo.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome do Imovel vendendo \n";
            }
            if (txtValorPedido.Text == "")
            {
                ret = false;
                campos += "- Valor \n";
            }

            if (txtNomeDoImovelCompra.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome do Imovel comprando \n";
            }

            if (!ret)
            {
                MessageBox.Show("Complete os campos solicitados \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        private void ControlarTela(int estadoDaTela)
        {
            switch (estadoDaTela)
            {
                case 1:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;
                case 2:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
            }
        }


    }
}
