using System.Globalization;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lados ret = new Lados();

            Console.WriteLine("Entre com a largura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Entre com a altura do retângulo: ");
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}