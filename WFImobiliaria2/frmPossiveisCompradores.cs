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
    public partial class frmPossiveisCompradores : Form
    {
        public frmPossiveisCompradores()
        {
            InitializeComponent();
        }
        
        private void CarregarGridPossiveisCompradores()
        {
            banco banco = new banco();

            var consultaClientes = banco.tb_cadastro.ToList();

            List<EncontrarVO> clienteEncontrado = new List<EncontrarVO>();
            foreach (var venda in consultaClientes)
            {
                foreach (var compra in consultaClientes)
                {
                    if(venda.ImovelVendendo == compra.ImovelComprando)
                    {
                        EncontrarVO encontrar = new EncontrarVO();

                        encontrar.Vendedor = venda.Nome;
                        encontrar.Imovel = venda.ImovelVendendo;
                        encontrar.Interessado = compra.Nome;
                        encontrar.Valor = Convert.ToDecimal(venda.Valor);

                        clienteEncontrado.Add(encontrar);

                    }
                }
            }

            grdPossiveisCompradores.DataSource = clienteEncontrado;

        }

       

        private void frmPossiveisCompradores_Load(object sender, EventArgs e)
        {
            CarregarGridPossiveisCompradores();
        }
    }
}
