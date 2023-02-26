using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string qualquerCoisa;
			Console.WriteLine("Escreva seu nome: ");
			qualquerCoisa =Console.ReadLine();
			string nomeMaiusculo = String.Format("Seu nome em maiúsculo é: {0}", qualquerCoisa.ToUpper());
			string nomeMinusculo = String.Format("Seu nome em minúsculo é: {0}", qualquerCoisa.ToLower());
			string nomeTrim = String.Format("Sem espaços: {0}", qualquerCoisa.Trim());
			string nomeSubString = String.Format("Substring value: {0}", qualquerCoisa.Substring(0,6));	
			
			Console.WriteLine(nomeMaiusculo);
			Console.WriteLine(nomeMinusculo);
			Console.WriteLine(nomeTrim);
			Console.WriteLine(nomeSubString);

			Console.ReadKey();
		}
	}
}