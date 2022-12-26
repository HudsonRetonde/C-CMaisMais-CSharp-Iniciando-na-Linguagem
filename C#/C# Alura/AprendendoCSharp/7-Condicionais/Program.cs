using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais.");

        int idade = 15;
        int quantidadeDePessoas = 1;

        if(idade >= 18)
        {
            Console.WriteLine("Possui maior idade penal, pode entrar!");
        }
        else
        {
            if(quantidadeDePessoas >1)
            {
                Console.WriteLine("Está acompanhado por responsável plenamente capaz, pode entrar.");
            } else
            {
                Console.WriteLine("Tem menos de 18 anos e está sozinho, não é permitida sua entrada!");
            }
        }

    
    }
}