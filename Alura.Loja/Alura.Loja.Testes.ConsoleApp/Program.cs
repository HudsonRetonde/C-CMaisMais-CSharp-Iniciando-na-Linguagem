using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var produtos = contexto.Produtos.ToList();

				ExibeEntries(contexto.ChangeTracker.Entries());

				produtos = contexto.Produtos.ToList();
							
                var novoProduto = new Produto()
                {
                    Nome = "Desinfetante",
                    Categoria = "Limpeza",
                    Preco = 2.99
                };
                contexto.Produtos.Add(novoProduto);

				
				produtos = contexto.Produtos.ToList();

                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();

				ExibeEntries(contexto.ChangeTracker.Entries());
			}


            Console.ReadKey();
        }  
        
        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
			Console.WriteLine("#####################");
			foreach (var e in entries)
			{
				Console.WriteLine("-------------------------");
				Console.WriteLine(e.Entity.ToString() + " - " + e.State);

			}
			Console.WriteLine("#####################");
		}
    }
}
