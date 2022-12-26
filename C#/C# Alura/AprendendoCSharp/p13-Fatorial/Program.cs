using System;

class Programa
{
    static void Main(String args[])
    {
        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
    }
}