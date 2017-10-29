using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EstoqueCliente.ServiceEstoque;

namespace EstoqueCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            ServiceEstoqueClient proxy = new ServiceEstoqueClient("BasicHttpBinding_IServicoEstoque");

            Console.WriteLine("Test 1: List all products");
            List<ProductData> products = proxy.ListProducts().ToList();
            foreach (ProductData p in products)
            {
                Console.WriteLine("Numero: {0}", p.NumeroProduto);
                Console.WriteLine("Nome: {0}", p.NomeProduto);
                Console.WriteLine("Descricao: {0}", p.DescricaoProduto);
                Console.WriteLine("Estoque: {0}", p.EstoqueProduto);
                Console.WriteLine();
            }
            Console.WriteLine();
            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
