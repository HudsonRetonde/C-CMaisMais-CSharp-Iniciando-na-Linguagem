using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Calcula Poupança com While.");

        double investimento = 100;
        int mes = 1;

        // Para um rendimento de 0.5%, utiliza-se 0.0005 ao mês.

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.0005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);
            mes++;
        }

        
    }
}