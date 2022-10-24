using System;
using Integracoes.Order.Model;

namespace Integracoes.Order
{
    public class OrderController
    {
        public void Integrar()
        {
            Console.WriteLine("Obtendo dados...");

            // Cria uma Instância 
            var _ctx = new Order();

            var resultado = _ctx.GetOrder();
            
            Console.WriteLine(resultado.Rows.Count + " dados obtidos");

            Console.WriteLine("Limpando Tabela");

            _ctx.Deletar();

            _ctx.Inserir(resultado);

            Console.WriteLine("Integração concluída");

        }
    }
}