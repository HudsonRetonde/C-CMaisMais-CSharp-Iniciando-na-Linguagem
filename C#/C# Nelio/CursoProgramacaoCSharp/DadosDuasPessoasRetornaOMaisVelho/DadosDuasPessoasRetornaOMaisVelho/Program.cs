using System.Security.Cryptography;

namespace DadosDuasPessoasRetornaOMaisVelho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario(); 
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: \n");
            Console.WriteLine("Nome do primeiro funcionário: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Idade do primeiro Funcionário: ");
            f1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Dados do segundo funcionário: \n");
            Console.WriteLine("Nome do segundo funcionário: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Idade do primeiro Funcionário: ");
            f2.Idade = int.Parse(Console.ReadLine());

            if (f1.Idade > f2.Idade)
            {
                Console.WriteLine($"{f1.Nome} é a pessoa mais velha, pois tem {f1.Idade} anos.");
            } else
            {
                Console.WriteLine($"{f2.Nome} é a pessoa mais velha, pois tem {f2.Idade} anos.");
            }
        }
    }
}