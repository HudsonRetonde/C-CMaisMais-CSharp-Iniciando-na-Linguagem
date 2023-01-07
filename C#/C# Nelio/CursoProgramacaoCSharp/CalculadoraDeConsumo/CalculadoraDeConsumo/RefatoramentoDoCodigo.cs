using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeConsumo
{
    internal class RefatoramentoDoCodigo
    {
        
        private double QtdDeCombustivel { get; set; }
        private double DistanciaPercorrida { get; set; }
        private double Consumo { get; set; }
        
        public void Executar()
        {
            ExbirCabecalho();
            RecebeCombustívelEDistancia();
            Relatorio();
        }

        private void ExbirCabecalho()
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("######### Calculadora de Comsumo de Combistível #########");
            Console.WriteLine("#########################################################");
            Console.WriteLine("");
        }

        private void RecebeCombustívelEDistancia()
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

            //Formula que efetua o consumo do veículo
            Consumo = DistanciaPercorrida / QtdDeCombustivel;            
            
        }

        private void Relatorio()
        {
            Console.WriteLine($"Com {QtdDeCombustivel.ToString("F2", CultureInfo.InvariantCulture)} L de combustível você percorreu {DistanciaPercorrida.ToString("F2", CultureInfo.InvariantCulture)} Km.");
            Console.WriteLine("");
            Console.WriteLine($"Logo, o consumo médio de combustível do seu veículo, em condições normais, é de {Consumo.ToString("F2", CultureInfo.InvariantCulture)} Km/L.");
            Console.ReadKey();
        }
    }
}
