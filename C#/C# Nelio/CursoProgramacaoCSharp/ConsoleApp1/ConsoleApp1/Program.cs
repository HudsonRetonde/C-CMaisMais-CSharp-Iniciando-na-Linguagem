using System;
using System.ComponentModel;
using System.Globalization;

namespace ConsoleApp1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos cômodos tem na sua casa? ");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o seu último nome, idade e altura (tudo na mesma linha)");
            string[] vect = Console.ReadLine().Split(' ');
            string lasName = vect[0];
            int age = int.Parse(vect[1]);
            double heigth = double.Parse((vect[2]), CultureInfo.InvariantCulture);


            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lasName);
            Console.WriteLine(age);
            Console.WriteLine(heigth.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}