using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomiaVeiculo
{
    internal class EstrutandoOCodigo
    {
        private double QtdDeCombustivel { get; set; }
        private double DistanciaPercorrida { get; set; }
        private double Consumo { get; set; }
        private double Autonomia { get; set; }
        public void Executar()
        {
            Cabecalho();
            RecebeCombustívelEDistanciaEAutonomia();
            Relatorio();
        }

        private void Cabecalho()
        {
            Console.WriteLine("##########################################################");
            Console.WriteLine("########### CALCULE A AUTONOMIA DO SEU VEÍCULO ###########");
            Console.WriteLine("##########################################################");
            Console.WriteLine("");
        }

        private void RecebeCombustívelEDistanciaEAutonomia()
        {
            Console.WriteLine("Quantos litros de combistível havia no seu tanque? ");
            //Recebe a informação e transforma para double
            QtdDeCombustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("Qual foi a distância percorrida em quilômetros? ");
            //Recebe a informação e transforma para double
            DistanciaPercorrida = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("");

            //Formula que efetua o consumo por km do veículo
            Consumo = DistanciaPercorrida / QtdDeCombustivel;

            //Formula que efetua a autonomia em km do veículo
            Autonomia = Consumo * QtdDeCombustivel;
        }
        private void Relatorio()
        {
            Console.WriteLine($"Com {QtdDeCombustivel.ToString("F2", CultureInfo.InvariantCulture)} L de combustível você percorreu {DistanciaPercorrida.ToString("F2", CultureInfo.InvariantCulture)} Km.");
            Console.WriteLine("");
            Console.WriteLine($"Logo, o consumo médio de combustível do seu veículo, em condições normais, é de {Consumo.ToString("F2", CultureInfo.InvariantCulture)} Km/L.");
            Console.WriteLine("");
            Console.WriteLine($"Por conseguinte, a autonomia do seu veículo é de {Autonomia} Km.");
            Console.ReadKey();

        }
    }
}
