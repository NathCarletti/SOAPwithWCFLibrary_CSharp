using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstoqueClienteV2.ServiceEstoqueV2;

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




            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
