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
