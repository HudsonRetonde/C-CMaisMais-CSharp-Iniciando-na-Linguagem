using System.Collections.Generic;

namespace TrabalhandoComListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("José");
            list.Add("Thiago");
            list.Add("João");
            list.Insert(2, "Marcos");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("O tamanho da lista é " + list.Count);

            string s1 = list.Find(x => x[0] == 'T');
            Console.WriteLine("A primeira ocorrência de um nome com a letra T é: " + s1);

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("A última ocorrência de um nome com a letra M é: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'J');
            Console.WriteLine("A primeira posição da letra J é: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("A última posição da letra J é: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length >= 5);
            Console.WriteLine("---------------------");
            foreach (string obj in list2)            
            {
                Console.WriteLine(obj);
            }

            list.Remove("Thiago");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}