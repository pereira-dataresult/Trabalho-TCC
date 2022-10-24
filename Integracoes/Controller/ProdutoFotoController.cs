using System;
using Integracoes.ProdutoFoto.Model;

namespace Integracoes.ProdutoFoto
{
    public class ProdutoFotoController
    {
        public void Integrar()
        {
            Console.WriteLine("Obtendo dados...");

            // Cria uma Instância 
            var _ctx = new ProdutoFoto();

            var resultado = _ctx.GetProdutoFoto();
            
            Console.WriteLine(resultado.Rows.Count + " dados obtidos");

            Console.WriteLine("Limpando Tabela");

            _ctx.Deletar();

            _ctx.Inserir(resultado);

            Console.WriteLine("Integração concluída");

        }
    }
}