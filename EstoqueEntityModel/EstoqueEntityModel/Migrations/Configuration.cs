namespace EstoqueEntityModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EstoqueEntityModel.ProvedorEstoque>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EstoqueEntityModel.ProvedorEstoque context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.ProdutoE.AddOrUpdate(

                new ProdutoEstoque { NumeroProduto = "100", NomeProduto = "Produto 01", DescricaoProduto = "Este é o produto 1", EstoqueProduto = 100 },
                new ProdutoEstoque { NumeroProduto = "200", NomeProduto = "Produto 02", DescricaoProduto = "Este é o produto 2", EstoqueProduto = 10 },
                new ProdutoEstoque { NumeroProduto = "300", NomeProduto = "Produto 03", DescricaoProduto = "Este é o produto 3", EstoqueProduto = 200 },
                new ProdutoEstoque { NumeroProduto = "400", NomeProduto = "Produto 04", DescricaoProduto = "Este é o produto 4", EstoqueProduto = 300 },
                new ProdutoEstoque { NumeroProduto = "500", NomeProduto = "Produto 05", DescricaoProduto = "Este é o produto 5", EstoqueProduto = 400 },
                new ProdutoEstoque { NumeroProduto = "600", NomeProduto = "Produto 06", DescricaoProduto = "Este é o produto 6", EstoqueProduto = 500 },
                new ProdutoEstoque { NumeroProduto = "700", NomeProduto = "Produto 07", DescricaoProduto = "Este é o produto 7", EstoqueProduto = 30 },
                new ProdutoEstoque { NumeroProduto = "800", NomeProduto = "Produto 08", DescricaoProduto = "Este é o produto 8", EstoqueProduto = 30 },
                new ProdutoEstoque { NumeroProduto = "900", NomeProduto = "Produto 09", DescricaoProduto = "Este é o produto 9", EstoqueProduto = 400 },
                new ProdutoEstoque { NumeroProduto = "1000", NomeProduto = "Produto 10", DescricaoProduto = "Este é o produto 10", EstoqueProduto = 2 }
                );
        }
    }
}
