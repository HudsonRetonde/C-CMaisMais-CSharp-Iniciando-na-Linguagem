using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    internal class Clientes
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataDeNascimento { get; set; }  
        public bool Situacao { get; set; }  

        
        public Clientes( string cpf, string nome, string endereco, DateTime dataDeNascimento)
        {
            CPF = cpf;
            Nome = nome;
            Endereco = endereco;
            DataDeNascimento = dataDeNascimento;
        }
        public Clientes(string nome)
        {

        }

        public Clientes()
        {
        }
    }
}
