using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Investimento a longo prazo.");

        double fatorDeRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <=12; mes ++)
            {
                investimento *= fatorDeRendimento;
            }
            fatorDeRendimento += 0.001;            
        }
        Console.WriteLine("Depois de 05 anos você terá: R$ " + investimento + " de investimento.");
    }
}