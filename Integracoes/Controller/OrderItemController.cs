using System;
using Integracoes.OrderItem.Model;

namespace Integracoes.OrderItem
{
    public class OrderItemController
    {
        public void Integrar()
        {
            Console.WriteLine("Obtendo dados...");

            // Cria uma Instância 
            var _ctx = new OrderItem();

            var resultado = _ctx.GetOrderItem();
            
            Console.WriteLine(resultado.Rows.Count + " dados obtidos");

            Console.WriteLine("Limpando Tabela");

            _ctx.Deletar();

            _ctx.Inserir(resultado);

            Console.WriteLine("Integração concluída");

        }
    }
}