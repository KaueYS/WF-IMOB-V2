using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClienteImovelMetodos
    {
        public void CadastrarDAO(tb_cadastro cadastro)
        {
            banco banco = new banco();

            banco.tb_cadastro.Add(cadastro);
            banco.SaveChanges();
        }



        public List<tb_cadastro> ConsultarClientes()
        {
            banco objBanco = new banco();
            List<tb_cadastro> lista = objBanco.tb_cadastro.ToList();

            return lista;

        }

        public void Alterar(tb_cadastro cad)
        {

            banco banco = new banco();
            
            banco.tb_cadastro.AddOrUpdate(cad);
            banco.SaveChanges();
        }

        
    }
}
