using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperarProduto();
            //ExcluirProdutos();
            //RecuperarProdutos();
            AtualizarProduto();
            Console.ReadKey();
        }

		private static void AtualizarProduto()
		{
            // inclui um produto
            GravarUsandoEntity();
            RecuperarProduto();

            //atualiza o produto
            using (var repo = new ProdutoDaoEntity())
			{
                Produto primeiro = repo.Produtos().First();
                primeiro.Nome = "Cassino Royale - Editado";
                repo.Atualizar(primeiro);
			}
            RecuperarProdutos();
        }

		private static void RecuperarProdutos()
		{
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                Console.WriteLine("Foram encontrados {0} produtos(s)", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

		private static void ExcluirProdutos()
		{
			using (var repo = new ProdutoDaoEntity())
			{
                IList<Produto> produtos = repo.Produtos();
				foreach (var item in produtos)
				{
					Console.WriteLine($"O produto {item} foi removido.");
                    repo.Remover(item);
				}
			}
		}

		private static void RecuperarProduto()
		{
            using (var repo = new ProdutoDaoEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                Console.WriteLine("Foram encontrados {0} produtos(s).", produtos.Count);
				foreach (var item in produtos)
				{
					Console.WriteLine(item.Nome);
				}
			}
		}

		private static void GravarUsandoEntity()
		{
            Produto p = new Produto();
            p.Nome = "Cassino Royale";
            p.Categoria = "Filmes";
            p.Preco = 19.89;

            
            using (var contexto = new ProdutoDaoEntity())
            {
                contexto.Adicionar(p);
            }
        }

		private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
