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

            Console.WriteLine("Test 2: Adicionar produto");
            ProductData productData2 = new ProductData();
            productData2.NumeroProduto = "11000";
            productData2.NomeProduto = "Produto 11";
            productData2.DescricaoProduto = "Este é o produto 11";
            productData2.EstoqueProduto = 300;
            proxy.IncluirProduto(productData2);
            Console.WriteLine("Numero: {0}", productData2.NumeroProduto);
            Console.WriteLine("Nome: {0}", productData2.NomeProduto);
            Console.WriteLine("Descricao: {0}", productData2.DescricaoProduto);
            Console.WriteLine("Estoque: {0}", productData2.EstoqueProduto);
            Console.WriteLine();

            Console.WriteLine("Test 3: Remover produto 10");
            bool remove = proxy.RemoverProduto("1000");
            Console.WriteLine(remove);

            Console.WriteLine("Test 4: Verificar produto 2");
            ProductData prod2 = proxy.VerProduto("200");
            Console.WriteLine("Numero: {0}", prod2.NumeroProduto);
            Console.WriteLine("Nome: {0}", prod2.NomeProduto);
            Console.WriteLine("Descricao: {0}", prod2.DescricaoProduto);
            Console.WriteLine("Estoque: {0}", prod2.EstoqueProduto);
            Console.WriteLine();

            Console.WriteLine("Test 5: Adicionar 10 ao estoque de produto 2");
            bool add = proxy.AdicionarEstoque("200", 10);
            Console.WriteLine(add);

            Console.WriteLine("Test 6: Verificar estoque do produto 2");
            int est = proxy.ConsultarEstoque("200");
            Console.WriteLine(est);

            Console.WriteLine("Test 7: Verificar estoque do produto 1");
            int est2 = proxy.ConsultarEstoque("100");
            Console.WriteLine(est2);

            Console.WriteLine("Test 8: Remover 20 ao estoque de produto 1");
            bool remove2 = proxy.RemoverEstoque("100",20);
            Console.WriteLine(remove2);

            Console.WriteLine("Test 9: Verificar estoque do produto 1");
            est2 = proxy.ConsultarEstoque("100");
            Console.WriteLine(est2);

            Console.WriteLine("Test 10: Verificar produto 1");
            prod2 = proxy.VerProduto("100");
            Console.WriteLine("Numero: {0}", prod2.NumeroProduto);
            Console.WriteLine("Nome: {0}", prod2.NomeProduto);
            Console.WriteLine("Descricao: {0}", prod2.DescricaoProduto);
            Console.WriteLine("Estoque: {0}", prod2.EstoqueProduto);
            Console.WriteLine();

            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
}
}
