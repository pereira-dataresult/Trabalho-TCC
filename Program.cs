using System;
using System.Diagnostics;
using Integracoes.CodLoja;
using Integracoes.Customer;
using Integracoes.Order;
using Integracoes.OrderItem;
using Integracoes.Payments;
using Integracoes.Produto;
using Integracoes.ProdutoFoto;

namespace ProjetoTcc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integração");
            Console.WriteLine("__________");

            Stopwatch time = new Stopwatch();
            time.Start();

            try
            {
                var CodLoja = new CodLojaController();
                CodLoja.Integrar();
            }
            catch (System.Exception e)
            {
                Console.whiteLine(e.Message);
            }

            try
            {
                var Customer = new CustomerController();
                Customer.Integrar();
            }
            catch (System.Exception e)
            {
                Console.whiteLine(e.Message);
            }

            try
            {
                var Order = new OrderController();
                Order.Integrar();
            }
            catch (System.Exception e)
            {
                Console.whiteLine(e.Message);
            }

            try
            {
               var OrderItem = new OrderItemController();
               OrderItem.Integrar();
            }
            catch (System.Exception e)
            {
                Console.whiteLine(e.Message);
            }

            try
            {
                var Payments = new PaymentsController();
                Payments.Integrar();
            }
            catch (System.Exception e)
            {
                Console.whiteLine(e.Message);
            }

            try
            {
                var Produto = new ProdutoController();
                Produto.Integrar();
            }
            catch (System.Exception e)
            {
                Console.whiteLine(e.Message);
            }

            try
            {
                var ProdutoFoto = new ProdutoFotoController();
                ProdutoFoto.Integrar();
            }
            catch (System.Exception e)
            {
                Console.whiteLine(e.Message);
            }

            time.Stop();

            TimeSpan ts =time.Elapsed;
            Console.WriteLine(ts.Seconds + " s");
            Console.ReadLine();

        }
    }
}
