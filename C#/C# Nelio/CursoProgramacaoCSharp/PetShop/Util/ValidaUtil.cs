using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetShop.Util
{
    internal static class ValidaUtil
    {
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static bool ValidaNascimento(string nascimento)
        {
            DateTime dataNascimento;
            if (!DateTime.TryParseExact(nascimento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
            {
                Console.WriteLine("Data fora do padrão requisitado. Por favor, insira novamente.");
                return false;
            }
            int idade = Convert.ToInt32(DateTime.Now.Year - dataNascimento.Year);
            if (!(idade >= 16 && idade <= 120))
            {
                Console.WriteLine("A idade mínima é 16 anos e a máxima é de 120!");
                Console.WriteLine("Digite novamente a data");
                return false;
            }
            return true;
        }

        public static bool ValidaNome(string nome)
        {
            if (nome is null or "")
            {
                return false;
            }
            if (!(nome.Length >= 3 && nome.Length <= 80))
            {
                return false;
            }
            string pattern = @"^[A-Z]*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(nome);
        }
        public static bool ValidaEndereco(string endereco)
        {
            if (endereco is null or "")
            {
                return false;
            }
            string pattern = @"^[a-zA-Z_0-9\s]*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(endereco);
        }
    }
}
