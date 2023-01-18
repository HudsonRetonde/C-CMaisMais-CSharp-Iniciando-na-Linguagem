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
        public DateTime DataDeNascimento { get; set; }  
        public string Endereco { get; set; }

        public Clientes()
        {

        }
        
        public Clientes( string cpf, string nome, DateTime dataDeNascimento, string endereco)
        {
            CPF = cpf;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Endereco = endereco;
        }
       

        
    }
}
