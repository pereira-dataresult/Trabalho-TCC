using System.Data;
using alphaframe.DAL;
using Connections;

namespace Integracoes.Produto.Model
{
    public class Produto
    {
        public DataTable GetProduto()
        {
            using (var dal = new DalSqlServer(Conexoes.AlphaBi))
            {
                // Coloca a Query onde vai consultar no banco de dados, onde vai obter as informações
                string sql = 
                    @"select
                    produto_foto_id,
                    produto_foto_referencia,
                    produto_foto_url,
                    produto_fotos_principal
                    from produto_fotos"; 
                return dal.Consultar(sql);
            }
        }
        public void Deletar()
        {
            using (var conexao = new DalSqlServer(Conexoes.Tcc))
            {
                string sql = "delete from produto_fotos";
                conexao.Executar(sql);
            }
        }
        
        public void Inserir(DataTable dt)
        {
            using (var dal = new DalSqlServer(Conexoes.Tcc))
            {
                // Coloca o nome da tablea na qual vai insertar as informações obtidas
                dal.Carregar(dt, "[produto_fotos]");
            }
        }
    }
}