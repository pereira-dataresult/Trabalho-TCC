using System;
using Integracoes.CodLoja.Model;

namespace Integracoes.CodLoja
{
    public class CodLojaController
    {
        public void Integrar()
        {
            Console.WriteLine("Obtendo dados...");

            // Cria uma Instância 
            var _ctx = new CodLoja();

            var resultado = _ctx.GetCodLoja();
            
            Console.WriteLine(resultado.Rows.Count + " dados obtidos");

            Console.WriteLine("Limpando Tabela");

            _ctx.Deletar();

            _ctx.Inserir(resultado);

            Console.WriteLine("Integração concluída");

        }
    }
}