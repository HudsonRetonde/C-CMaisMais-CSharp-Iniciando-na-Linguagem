using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5. Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(81 + 2);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia.";
        Console.WriteLine(primeiraFrase);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos Disponníveis: 
- Go, 
- CSharp, 
- Python e 
- Java";
        Console.WriteLine(cursos);
    }
}