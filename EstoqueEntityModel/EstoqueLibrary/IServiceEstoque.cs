using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
namespace Products
{
    // Data contract describing the details of a product passed to client applications
    [DataContract]
    public class ProductData
    {
        [DataMember]
        public string NumeroProduto;
        [DataMember]
        public string NomeProduto;
        [DataMember]
        public string DescricaoProduto;
        [DataMember]
        public int EstoqueProduto;
    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01")]
    public interface IServiceEstoque
    {
        // Get all products
        [OperationContract]
        List<ProductData> ListProducts();

        [OperationContract]
        bool IncluirProduto(ProductData productData);

        [OperationContract]
        bool RemoverProduto(string NumeroProduto);

        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int quantidade);

        [OperationContract]
        ProductData VerProduto(string NumeroProduto);

    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02")]
    public interface IServicoEstoqueV2
    {
        [OperationContract]
        bool AdicionarEstoque(String numeroProduto, int quantidade);

        [OperationContract]
        bool RemoverEstoque(String numeroProduto, int quantidade);

        [OperationContract]
        int ConsultarEstoque(String numeroProduto);
    }

}

