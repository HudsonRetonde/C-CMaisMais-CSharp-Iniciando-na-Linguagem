using PetShop_Arquivo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PetShop_Arquivo.Repositorios
{
    internal class ClienteRepositorio
    {
        private readonly string _caminhoBase = "C:\\ProjetosRumo\\DatabaseLocais\\produto.csv";
        private List<Cliente> ListagemClientes = new List<Cliente>();

        #region Métodos Públicos
        public ClienteRepositorio()
        {
            if (!File.Exists(_caminhoBase))
            {
                var file = File.Create(_caminhoBase);
                file.Close();
            }
        }
        public void Inserir(Cliente cliente)
        {
            if (!(VerificaExistenciaCliente(cliente.CPF)))
            {
                var sw = new StreamWriter(_caminhoBase);

                sw.WriteLine($"{cliente.Nome};{cliente.CPF};{cliente.DataNascimento};{cliente.Endereco}");
                Console.WriteLine();
                Console.WriteLine("Cliente cadastrado com sucesso!\n");
                sw.Close();
            }
            Console.WriteLine("CPF já utilizado, cadastro cancelado.");
        }
        public List<Cliente> Listar()
        {
            CarregarClientesLista();

            return ListagemClientes;
        }
        #endregion

        #region Métodos Privados
        private Cliente LinhaTextoParaCliente(string linha)
        {
            var colunas = linha.Split(';');

            var cliente = new Cliente();
            cliente.Nome = colunas[0];
            cliente.CPF = colunas[1];
            cliente.DataNascimento = Convert.ToDateTime(colunas[2]);
            cliente.Endereco = colunas[3];

            return cliente;
        }

        private void CarregarClientesLista()
        {
            ListagemClientes.Clear();
            var sr = new StreamReader(_caminhoBase);
            while (true)
            { 
                var linha = sr.ReadLine();

                if (linha == null)
                    break;
                
                ListagemClientes.Add(LinhaTextoParaCliente(linha));
            }
            
            sr.Close();
        }

        private bool VerificaExistenciaCliente(string cpf)
        {
            CarregarClientesLista();
            Cliente cliente = ListagemClientes.Find(c => c.CPF == cpf);
            
            if(cliente == null)
                return false;
            else
                return true;

        }
        #endregion
    }
}
