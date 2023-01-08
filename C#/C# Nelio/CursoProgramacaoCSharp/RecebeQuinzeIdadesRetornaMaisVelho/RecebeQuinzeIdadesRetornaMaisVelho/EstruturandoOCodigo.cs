using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecebeDezIdadesRetornaMaisVelho
{
    internal class EstruturandoOCodigo
    {
        private int NumeroDePessoas {get; set;}
        private int MaisVelho { get; set;}   
        private string NomeDoMaisVelho { get; set;}
        private string[] Nomes { get; set;}
        private int[] Idades { get; set;}
        public void Executar()
        {
            Cabecalho();
            CapturandoDados();
            Instrucoes();
            LeituraEProgramacaoDosDados();
            Relatorio();
        }

        private void Cabecalho()
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("######### COMPARA IDADES E RETORNA O MAIS VELHO #########");
            Console.WriteLine("#########################################################");
            Console.WriteLine("");
        }      

        private void CapturandoDados()
        {
            NumeroDePessoas = 10;
            MaisVelho = 0;
            NomeDoMaisVelho = "";


            Nomes = new string[NumeroDePessoas];
            Idades = new int[NumeroDePessoas];
        }
        private void Instrucoes()
        {
            Console.WriteLine("Escreva o nome e a idade de dez pessoas: ");
            Console.WriteLine("Para cada idade, escreva o nome depois a idade na mesma linha.");
            Console.WriteLine("Por exemplo: José 25");
            Console.WriteLine("");
        }

        private void LeituraEProgramacaoDosDados()
        {
            for (int cont = 0; cont < NumeroDePessoas; cont++)
            {
                Console.WriteLine($"Escreva o nome e a idade da {cont + 1}a pessoa: ");
                string[] s = Console.ReadLine().Split(' ');
                Nomes[cont] = s[0];
                Idades[cont] = int.Parse(s[1]);

                if (cont == 1)
                {
                    MaisVelho = Idades[cont];
                    NomeDoMaisVelho = Nomes[cont];
                }
                else
                {
                    if (Idades[cont] > MaisVelho)
                    {
                        MaisVelho = Idades[cont];
                        NomeDoMaisVelho = Nomes[cont];
                    }
                }

            }
        }
        private void Relatorio()
        {
            Console.WriteLine($"O(a) {NomeDoMaisVelho} é o(a) mais velho(a) da comparação e possui {MaisVelho} anos de idade.");
        }
    }
}
