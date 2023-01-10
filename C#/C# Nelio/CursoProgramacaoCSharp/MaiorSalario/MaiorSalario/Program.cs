namespace MaiorSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario p1 = new Funcionario(); 
            Funcionario p2 = new Funcionario();

            Console.WriteLine("Caparativo de Maior Salário \n");
            Console.WriteLine("Escreva o nome do primeiro funcionário: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do seu salário: \n\n");
            p1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o nome do segundo funcionário: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do seu salário: \n\n");
            p2.Salario = int.Parse(Console.ReadLine());

            if (p1.Salario > p2.Salario)
            {
                Console.WriteLine($"{p1.Nome} tem o maior salário, pois recebe R#: {p1.Salario}.");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} tem o maior salário, pois recebe R#: {p2.Salario}.");
            }
        }
    }
}