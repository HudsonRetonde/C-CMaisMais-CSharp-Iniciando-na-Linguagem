using System.Globalization;
using DadosBancarios;

namespace DadosBancarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Informe o Id do funcionário que terá aumento salarial: ");
            int buscaid = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == buscaid);
            if (func != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.SalarioIncremento(porcentagem);
            }
            else
            {
                Console.WriteLine("Este Id não existe... Digite um Id válido.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcuinários: ");

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}