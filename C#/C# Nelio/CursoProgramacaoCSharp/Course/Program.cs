using System;
using System.Globalization;
using System.Net.WebSockets;
using ContaBancaria;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o tiular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inidicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria (numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            conta.Deposito(quantia);
            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            conta.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine(conta);

        }

    }
}