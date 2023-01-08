using System.Collections.Concurrent;

namespace LucroDoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite a quantidade de produtos que deseja verificar");
            int qtdProdutos;
            qtdProdutos = int.Parse(Console.ReadLine());
            int cont = 0;

            string[] produtos = new string[qtdProdutos];

            Console.WriteLine("");

            while (cont < qtdProdutos)
            {
                Console.WriteLine($"Por gentileza, digite 0 {cont + 1}° produto: ");
                string nomeProduto;
                nomeProduto = Console.ReadLine();
                produtos[cont] = nomeProduto;
                cont++;
            }
            

            Console.WriteLine("");

            var matrizQuantidadePCompraPVenda = new double[qtdProdutos, 3];


            Console.WriteLine("Descreva o item do pruudto na seguinte ordem: ");
            Console.WriteLine("Quantidade (coluna1), Preço de Compra (coluna2) e Preço de Venda (coluna3):");
            Console.WriteLine("Por exemplo: 5 6.00 12.00");

            for (int l = 0; l < qtdProdutos; l++)
            {

                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine($"Digite os números do {l +1}° produto coluna {c +1}: ");
                    double qtdPcPvProduto = double.Parse(Console.ReadLine());
                    matrizQuantidadePCompraPVenda[l, c] = qtdPcPvProduto;
                    
                }
            }

            double lucroDoProduto = 0.0;
            double lucrototal = 0.00;

            for (int l = 0; l < qtdProdutos; l++)
            {

                for (int c = 0; c < 3; c++)
                {
                    lucroDoProduto = (matrizQuantidadePCompraPVenda[l,2] - matrizQuantidadePCompraPVenda[l, 1]) * matrizQuantidadePCompraPVenda[l, 0];
                    
                }

                lucrototal = lucroDoProduto + lucrototal;
                Console.WriteLine($"O lucro do produto {l + 1} foi de R$: {lucroDoProduto}");
               

            }

            Console.WriteLine($"O lucro total, na soma do lucro de todos os produtos é de {lucrototal}");

        }
    }
}