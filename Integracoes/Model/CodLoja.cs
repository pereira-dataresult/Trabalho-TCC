using System.Data;
using alphaframe.DAL;
using Connections;

namespace Integracoes.CodLoja.Model
{
    public class CodLoja
    {
        public DataTable GetCodLoja()
        {
            using (var dal = new DalSqlServer(Conexoes.vtex))
            {
                // Coloca a Query onde vai consultar no banco de dados, onde vai obter as informações
                string sql = 
                    @"select
                    cadastro_de_vendedora_codvtex CodVtex,
                    cadastro_de_vendedora_lojaid LojaId,
                    cadastro_de_vendedora_loja Loja,
                    cadastro_de_vendedora_canal Canal,
                    case cadastro_de_vendedora_ativo when '1' then 'TRUE' else 'FALSE' end Status_Loja
                    from cadastro_de_vendedoras"; 
                return dal.Consultar(sql);
            }
        }
        public void Deletar()
        {
            using (var conexao = new DalSqlServer(Conexoes.Tcc))
            {
                string sql = "delete from cod_loja";
                conexao.Executar(sql);
            }
        }
        
        public void Inserir(DataTable dt)
        {
            using (var dal = new DalSqlServer(Conexoes.Tcc))
            {
                // Coloca o nome da tablea na qual vai insertar as informações obtidas
                dal.Carregar(dt, "[cod_loja]");
            }
        }
    }
}