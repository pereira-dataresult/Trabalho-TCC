using System.Data;
using alphaframe.DAL;
using Connections;

namespace Integracoes.Payments.Model
{
    public class Payments
    {
        public DataTable GetPayments()
        {
            using (var dal = new DalSqlServer(Conexoes.vtex))
            {
                // Coloca a Query onde vai consultar no banco de dados, onde vai obter as informações
                string sql = 
                    @"SELECT
                    id,
                    OrderId,
                    SistenName,
                    Valor,
                    [NumParcelas]
                     FROM payments"; 
                return dal.Consultar(sql);
            }
        }
        public void Deletar()
        {
            using (var conexao = new DalSqlServer(Conexoes.Tcc))
            {
                string sql = "delete from Payments";
                conexao.Executar(sql);
            }
        }
        
        public void Inserir(DataTable dt)
        {
            using (var dal = new DalSqlServer(Conexoes.Tcc))
            {
                // Coloca o nome da tablea na qual vai insertar as informações obtidas
                dal.Carregar(dt, "[Payments]");
            }
        }
    }
}