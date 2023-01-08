using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucroDoProduto
{
    internal class EstruturaOCodigo
    {
        private int QtdProdutos { get; set; }
        private string[] Produtos { get; set; }
        private double[,] MatrizQuantidadePCompraPVenda { get; set; }
        private double QtdPcPvProduto { get; set; }
        private double LucroDoProduto { get; set; }
        private double Lucrototal { get; set; }
        public void Executar()
        {
            Cabecalho();
            QtdDeProdutosAnalisar();
            CriaMatriz();
            CalculaLucroLucroTotal();
        }

        private void Cabecalho()
        {
            Console.WriteLine("########################################################");
            Console.WriteLine("############### RETORNA O LUCRO DO PRODUTO #############");
            Console.WriteLine("########################################################");
            Console.WriteLine("");
        }
        private void QtdDeProdutosAnalisar() {

            Console.WriteLine("Digite a quantidade de produtos que deseja verificar");
           
            QtdProdutos = int.Parse(Console.ReadLine());
            int cont = 0;

            Produtos = new string[QtdProdutos];

            Console.WriteLine("");

            while (cont < QtdProdutos)
            {
                Console.WriteLine($"Por gentileza, digite 0 {cont + 1}° produto: ");
                string nomeProduto;
                nomeProduto = Console.ReadLine();
                Produtos[cont] = nomeProduto;
                cont++;
            }

            Console.WriteLine("");
        }

        private void CriaMatriz()
        {

            MatrizQuantidadePCompraPVenda = new double[QtdProdutos, 3];


            Console.WriteLine("Descreva o item do pruudto na seguinte ordem: ");
            Console.WriteLine("Quantidade (coluna1), Preço de Compra (coluna2) e Preço de Venda (coluna3):");
            Console.WriteLine("Por exemplo: 5 6.00 12.00");

            for (int l = 0; l< QtdProdutos; l++)
            {

                for (int c = 0; c< 3; c++)
                {
                    Console.WriteLine($"Digite os números do {l +1}° produto coluna {c +1}: ");
                    QtdPcPvProduto = double.Parse(Console.ReadLine());
                    MatrizQuantidadePCompraPVenda[l, c] = QtdPcPvProduto;
                    
                }
}
        }

        private void CalculaLucroLucroTotal()
        {

            LucroDoProduto = 0.0;
            Lucrototal = 0.00;

            for (int l = 0; l < QtdProdutos; l++)
            {

                for (int c = 0; c < 3; c++)
                {
                    LucroDoProduto = (MatrizQuantidadePCompraPVenda[l, 2] - MatrizQuantidadePCompraPVenda[l, 1]) * MatrizQuantidadePCompraPVenda[l, 0];
                    
                }

                Lucrototal = LucroDoProduto + Lucrototal;
                Console.WriteLine($"O lucro do produto {l + 1} foi de R$: {LucroDoProduto}");
                
            }
            Console.WriteLine($"O lucro total, na soma do lucro de todos os produtos é de {Lucrototal}");
        }
    }
}
