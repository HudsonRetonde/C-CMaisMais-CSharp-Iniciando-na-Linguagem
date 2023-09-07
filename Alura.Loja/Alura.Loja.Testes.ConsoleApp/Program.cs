using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var produtos = contexto.Produtos.ToList();
                foreach (var produto in produtos)
                {
                    Console.WriteLine(produto);
                }

				Console.WriteLine("###################");
				produtos = contexto.Produtos.ToList();
				foreach (var e in contexto.ChangeTracker.Entries())
				{
					Console.WriteLine(e.State);
				}

				var p1 = produtos.Last();
                p1.Nome = "007 - Um novo Dia para Morrer"
;               contexto.SaveChanges();				

				Console.WriteLine("###################");
				produtos = contexto.Produtos.ToList();
				foreach (var e in contexto.ChangeTracker.Entries())
				{
					Console.WriteLine(e.State);
				}
			}


            Console.ReadKey();
        }        
    }
}
