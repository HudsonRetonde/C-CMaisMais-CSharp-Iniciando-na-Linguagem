using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Encadeando For.");

        //*
        //**
        //***
        //****
        //*****

        for (int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
        {
            for (int contadorDeColunas = 0; contadorDeColunas < 10; contadorDeColunas++)
            {
                Console.Write("*");
                if (contadorDeColunas >= contadorDeLinhas)
                    break;
            }
            Console.WriteLine();
        }
        
    }
}