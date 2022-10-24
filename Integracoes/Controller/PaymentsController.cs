using System;
using Integracoes.Payments.Model;

namespace Integracoes.Payments
{
    public class PaymentsController
    {
        public void Integrar()
        {
            Console.WriteLine("Obtendo dados...");

            // Cria uma Instância 
            var _ctx = new Payments();

            var resultado = _ctx.GetPayments();
            
            Console.WriteLine(resultado.Rows.Count + " dados obtidos");

            Console.WriteLine("Limpando Tabela");

            _ctx.Deletar();

            _ctx.Inserir(resultado);

            Console.WriteLine("Integração concluída");

        }
    }
}