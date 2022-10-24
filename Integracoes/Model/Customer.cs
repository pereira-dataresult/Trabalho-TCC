using System.Data;
using alphaframe.DAL;
using Connections;

namespace Integracoes.Customer.Model
{
    public class Customer
    {
        public DataTable GetCustomer()
        {
            using (var dal = new DalSqlServer(Conexoes.vtex))
            {
                // Coloca a Query onde vai consultar no banco de dados, onde vai obter as informações
                string sql = 
                    @"select
                    id,
                    Nome,
                    Cidade,
                    Estado
                    from Customer"; 
                return dal.Consultar(sql);
            }
        }
        public void Deletar()
        {
            using (var conexao = new DalSqlServer(Conexoes.Tcc))
            {
                string sql = "delete from Customer";
                conexao.Executar(sql);
            }
        }
        
        public void Inserir(DataTable dt)
        {
            using (var dal = new DalSqlServer(Conexoes.Tcc))
            {
                // Coloca o nome da tablea na qual vai insertar as informações obtidas
                dal.Carregar(dt, "[Customer]");
            }
        }
    }
}