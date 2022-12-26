using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais.");

        int idade = 15;
        int quantidadeDePessoas = 2;

        if (idade >= 18 || quantidadeDePessoas > 1)
        {
            Console.WriteLine("Possui maior idade penal ou está acompanhado, pode entrar!");
        }
        else
        {            
                Console.WriteLine("Tem menos de 18 anos ou está sozinho, não é permitida sua entrada!");
        }
    }
}