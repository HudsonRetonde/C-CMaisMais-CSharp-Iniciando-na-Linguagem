using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestrinchandoDadosDoVendedor
{
    internal class EstruturandoCodigo
    {
        private string NomeVendedor { get; set; }
        private double SalarioFixo { get; set; }
        private double VendasAcumuladasMes { get; set; }
        private double Comissao { get; set; }
        private double SalarioBruto { get; set; }
        public void Executar()
        {
            Cabecalho();
            RecebeInformacoesDoVendedor();
            CalculaComissao();
            CalculaSalarioBruto();
            Relatorio();
        }
        private void Cabecalho()
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("############ DESTRINCHANDO DADOS DO VENDEDOR ############");
            Console.WriteLine("#########################################################");
            Console.WriteLine("");
        }

        private void RecebeInformacoesDoVendedor()
        {
            Console.WriteLine("Qual o nome do(a) vendedor(a): ");
            NomeVendedor = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Por gentileza, informe o salário fixo do vendedor(a) em R$: ");
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("Por fim, informe o total de vendas em R$ acumuladas no mês :");
            VendasAcumuladasMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

        }

        private void CalculaComissao()
        {
            Comissao = VendasAcumuladasMes * 0.15;
        }

        private void CalculaSalarioBruto()
        {
            SalarioBruto = SalarioFixo + Comissao;
        }

        private void Relatorio()
        {
            Console.WriteLine($"Como o total de vendas no mês do(a) vendedor(a) {NomeVendedor} foi de R$: {VendasAcumuladasMes.ToString("F2", CultureInfo.InvariantCulture)}.");            
            Console.WriteLine($"Sua comissão é R$: {Comissao.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"Por conseguite, sua remuneração total, que é a soma do salário fixo R$: {SalarioFixo} + comissão {Comissao}, ");            
            Console.WriteLine($"é de R$: {SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
