using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecebeQuinzeNumerosExibePositivos
{
    internal class EstruturandoOCodigo
    {
        private int QtdNumers { get; set; }
        private int Cont { get; set; }
        private int[] Vetor { get; set; }
        public void Executar()
        {
            Cabecalho();
            RecebeNumeros();
            EscrevePositivos();
        }
        private void Cabecalho()
        {
            Console.WriteLine("########################################################");
            Console.WriteLine("######## RECEBE 10 NÚMEROS E RETORNA OS POSITIVOS ######");
            Console.WriteLine("########################################################");
            Console.WriteLine("");

        }

        private void RecebeNumeros()
        {
            QtdNumers = 15;
            Cont = 0;

            Vetor = new int[QtdNumers];

            while (Cont < 4)
            {
                Console.WriteLine($"Por gentileza, digite 0 {Cont + 1}° número: ");
                int numero;
                numero = int.Parse(Console.ReadLine());
                Vetor[Cont] = numero;
                Cont++;
            }

            Console.WriteLine("");
        }
        private void EscrevePositivos()
        {
            for (int i = 0; i < QtdNumers; i++)
            {
                if (Vetor[i] > 0)
                {
                    Console.WriteLine($"O número {Vetor[i]} é positivo, logo foi impresso.");
                }
            }
        }
    }

}
