using System;
using System.Globalization;

namespace MyApp 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numero, digito, soma =0;

			Console.WriteLine("##########################################################");
			Console.WriteLine("############### MOSTRA A SOMA DOS DÍGITOS  ###############");
			Console.WriteLine("##########################################################");
			Console.WriteLine("");

			Console.WriteLine("Por genteileza, digite um número inteiro que queira verificar: ");
			numero = int.Parse(Console.ReadLine());
			Console.WriteLine("");

			while (numero > 0) 
			{
				digito = numero % 10;
				soma = soma + digito;
				numero = numero / 10;
			}

			Console.WriteLine($"A soma dos dígitos do número é {soma}.");  
				
			
	}
	}
}