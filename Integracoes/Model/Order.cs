using System.Data;
using alphaframe.DAL;
using Connections;

namespace Integracoes.Order.Model
{
    public class Order
    {
        public DataTable GetOrder()
        {
            using (var dal = new DalSqlServer(Conexoes.vtex))
            {
                // Coloca a Query onde vai consultar no banco de dados, onde vai obter as informações
                string sql = 
                    @"select
                    OrderId,
                    ClienteId,
                    [Status],
                    ValorTotalPedido,
                    DataPedido,
                    ValorPedido,
                    ValorDesconto,
                    VendedoraId,
                    Transportadora,
                    DataFaturamento,
                    NotaFiscal
                    from [Order]
                    where DataPedido BETWEEN '20190101' and '20211231'
                    and [Status] IS NOT NULL"; 
                return dal.Consultar(sql);
            }
        }
        public void Deletar()
        {
            using (var conexao = new DalSqlServer(Conexoes.Tcc))
            {
                string sql = "delete from Order";
                conexao.Executar(sql);
            }
        }
        
        public void Inserir(DataTable dt)
        {
            using (var dal = new DalSqlServer(Conexoes.Tcc))
            {
                // Coloca o nome da tablea na qual vai insertar as informações obtidas
                dal.Carregar(dt, "[Order]");
            }
        }
    }
}