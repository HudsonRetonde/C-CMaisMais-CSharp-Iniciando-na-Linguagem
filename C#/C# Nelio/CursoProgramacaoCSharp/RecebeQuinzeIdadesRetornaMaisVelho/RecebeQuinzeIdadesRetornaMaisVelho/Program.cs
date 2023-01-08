namespace RecebeDezIdadesRetornaMaisVelho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var executaPrograma = new EstruturandoOCodigo();
            executaPrograma.Executar();
            
            
            //Tinha feito a lógica sem usar vetor, refiz com vetor, conforme segue na classe EstruturandoOCodigo
            //Deixei este comentado só para não perder.

            //int N = 10;
            //int maisVelho = 0;
            //int idade;
            //string nome;
            //string nomeDoMaisVelho = "";

            ////Leitura dos dados
            //for (int cont = 0; cont < N; cont++)
            //{
            //    Console.WriteLine($"Escreva o {cont + 1}° nome: ");
            //    nome = Console.ReadLine();
            //    Console.WriteLine($"Digite a  {cont + 1} a idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (cont == 1)
            //    {
            //        maisVelho = idade;
            //        nomeDoMaisVelho = nome;
            //    } else
            //    {
            //        if(idade > maisVelho)
            //        {
            //            maisVelho = idade;
            //            nomeDoMaisVelho = nome;
            //        }
            //    }
            //}

            //Console.WriteLine($"O(a) {nomeDoMaisVelho} é o(a) mais velho(a) da comparação e possui {maisVelho} anos de idade.");

        }
    }
}