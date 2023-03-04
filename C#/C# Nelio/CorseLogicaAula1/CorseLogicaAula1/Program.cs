using System;

namespace CourseLogicaAula1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Entre com a string");
			string input = Console.ReadLine();

			Console.WriteLine("Entre com uma letra");
			char serachInput = Console.ReadLine()[0];

			int searchIndex = input.IndexOf(serachInput);
			Console.WriteLine("O index do caracter {0} na string é {1}", serachInput, searchIndex);


			Console.WriteLine("entre com o primeiro nome: ");
			string firstName =  Console.ReadLine();
			Console.WriteLine("Entre com o sobrenome: ");
			string lastName = Console.ReadLine();

			string fullName = string.Concat(firstName, " ", lastName);
			Console.WriteLine("Seu nome completo é {0}", fullName);

			Console.ReadKey();
		}
	}
}