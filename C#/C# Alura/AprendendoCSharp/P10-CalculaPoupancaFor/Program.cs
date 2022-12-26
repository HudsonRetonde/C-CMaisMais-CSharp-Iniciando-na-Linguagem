using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Calcula Poupança com For.");

        double investimento = 100;
        

        // Para um rendimento de 0.5%, utiliza-se 0.0005 ao mês.

        for (int mes = 1; mes <= 12; mes ++ )
        {
            investimento = investimento + investimento * 0.0005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);
           
        }


    }
}