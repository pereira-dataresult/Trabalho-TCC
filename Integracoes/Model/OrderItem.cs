using System.Data;
using alphaframe.DAL;
using Connections;

namespace Integracoes.OrderItem.Model
{
    public class OrderItem
    {
        public DataTable GetOrderItem()
        {
            using (var dal = new DalSqlServer(Conexoes.vtex))
            {
                // Coloca a Query onde vai consultar no banco de dados, onde vai obter as informações
                string sql = 
                    @"select
                    UniqueId,
                    OrderId,
                    [Status],
                    DataPedido,
                    SKU,
                    Quantidade,
                    ValorUnitario,
                    ValorDesconto,
                    ValorFrete,
                    FreteCliente
                     from [OrderItem]
                    where DataPedido BETWEEN '20190801' and '20210831'
                    and [Status] IS NOT NULL"; 
                return dal.Consultar(sql);
            }
        }
        public void Deletar()
        {
            using (var conexao = new DalSqlServer(Conexoes.Tcc))
            {
                string sql = "delete from OrderItem";
                conexao.Executar(sql);
            }
        }
        
        public void Inserir(DataTable dt)
        {
            using (var dal = new DalSqlServer(Conexoes.Tcc))
            {
                // Coloca o nome da tablea na qual vai insertar as informações obtidas
                dal.Carregar(dt, "[OrderItem]");
            }
        }
    }
}