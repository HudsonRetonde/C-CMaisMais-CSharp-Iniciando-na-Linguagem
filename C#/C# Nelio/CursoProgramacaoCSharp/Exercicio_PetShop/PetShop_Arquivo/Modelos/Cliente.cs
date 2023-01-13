using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Arquivo.Modelos
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public Cliente() 
        { 
            
        }
        public Cliente(string nome, string cpf, DateTime dataNascimento, string endereco)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }
    }
}
