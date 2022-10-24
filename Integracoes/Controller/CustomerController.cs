using System;
using Integracoes.Customer.Model;

namespace Integracoes.Customer
{
    public class CustomerController
    {
        public void Integrar()
        {
            Console.WriteLine("Obtendo dados...");

            // Cria uma Instância 
            var _ctx = new Customer();

            var resultado = _ctx.GetCustomer();
            
            Console.WriteLine(resultado.Rows.Count + " dados obtidos");

            Console.WriteLine("Limpando Tabela");

            _ctx.Deletar();

            _ctx.Inserir(resultado);

            Console.WriteLine("Integração concluída");

        }
    }
}