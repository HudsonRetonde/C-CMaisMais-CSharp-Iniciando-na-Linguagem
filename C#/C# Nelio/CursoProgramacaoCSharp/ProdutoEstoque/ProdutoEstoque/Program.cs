using System.Globalization;

namespace ProdutoEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Dados do produto: \n" + p);

            Console.WriteLine("Digite o número de produtos a serem adcionados no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine(""); 
            Console.WriteLine("Digite o número de produtos a serem adcionados no estoque: \n");
            int qtdRet = int.Parse(Console.ReadLine());
            p.RetirarProdutos(qtdRet);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}