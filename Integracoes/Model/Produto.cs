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
                    cadastro_de_produtos_sku SKU,
                    cadastro_de_produtos_cod EAN,
                    cadastro_de_produtos_referencia REFERENCIA,
                    cadastro_de_produtos_nome NOME_PRODUTO,
                    cadastro_de_produtos_colecao COLECAO,
                    cadastro_de_produtos_grupo GRUPO,
                    cadastro_de_produtos_categoria CATEGORIA,
                    cadastro_de_produtos_cor COR,
                    cadastro_de_produtos_tamanho TAMANHO,
                    cadastro_de_produtos_mapa MAPA,
                    cadastro_de_produtos_peso PESO,
                    'un' U_M
                    from cadastro_de_produtos"; 
                return dal.Consultar(sql);
            }
        }
        public void Deletar()
        {
            using (var conexao = new DalSqlServer(Conexoes.Tcc))
            {
                string sql = "delete from produtos";
                conexao.Executar(sql);
            }
        }
        
        public void Inserir(DataTable dt)
        {
            using (var dal = new DalSqlServer(Conexoes.Tcc))
            {
                // Coloca o nome da tablea na qual vai insertar as informações obtidas
                dal.Carregar(dt, "[produtos]");
            }
        }
    }
}