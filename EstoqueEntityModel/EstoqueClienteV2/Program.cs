using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstoqueClienteV2.ServiceEstoque;

namespace EstoqueClienteV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            //ServicoEstoqueV2Client proxy = new ServicoEstoqueV2Client("NetTcpBinding_IServiceEstoquV2");
            ServicoEstoqueV2Client proxy = new ServicoEstoqueV2Client("WS2007HttpBinding_IServicoEstoqueV2");
            Console.WriteLine("Test 1: Verificar o estoque atual do Produto 1");
            int consulta = proxy.ConsultarEstoque("100");
            Console.WriteLine("Estoque: {0}", consulta);
            Console.WriteLine();

            Console.WriteLine("Test 2: Adicionar 20 ao estoque");
            bool add = proxy.AdicionarEstoque("100", 10);
            Console.WriteLine(add);

            Console.WriteLine("Test 3: Verificar estoque do produto 1");
           int est = proxy.ConsultarEstoque("100");
            Console.WriteLine(est);

            Console.WriteLine("Test 4: Verificar o estoque do produto 5");
            est = proxy.ConsultarEstoque("500");
            Console.WriteLine(est);

            Console.WriteLine("Test 5: Remover 10 ao estoque de 5");
            bool remove = proxy.RemoverEstoque("500",10);
            Console.WriteLine(remove);

            Console.WriteLine("Test 6: Verificar o estoque do produto 5");
            est = proxy.ConsultarEstoque("500");
            Console.WriteLine(est);
            proxy.Close();

            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
