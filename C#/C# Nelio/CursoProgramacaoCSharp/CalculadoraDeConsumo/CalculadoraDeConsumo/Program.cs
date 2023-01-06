using System;

namespace CalculadoraDeConsumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("######### Calculadora de Comsumo de Combistível #########");
            Console.WriteLine("#########################################################");

            Console.WriteLine("Quantos litros de combistível havia no su tanque? ");
            double qtdDeCombustivel = double.Parse(Console.ReadLine());
            Console.WriteLine(qtdDeCombustivel);
        }
    }
}