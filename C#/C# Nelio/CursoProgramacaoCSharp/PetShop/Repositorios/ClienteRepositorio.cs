using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PetShop.Repositorios
{
    internal class ClienteRepositorio
    {
        private readonly string _caminhoBase = "C:\\Users\\hudso\\OneDrive\\Documentos\\C#\\C-Iniciando-na-Linguagem\\C#\\C# Nelio\\CursoProgramacaoCSharp\\DataBasesLocais\\clientes.csv";
        private List<Clientes> ListagemClientes = new List<Clientes>();

        #region Métodos Públicos
        public ClienteRepositorio()
        {
            if (!File.Exists(_caminhoBase))
            {
                var file = File.Create(_caminhoBase);
                file.Close();
            }
        }
        public void Inserir(Clientes cliente)
        {
            if (!(VerificaExistenciaCliente(cliente.CPF)))
            {
                var sw = new StreamWriter(_caminhoBase);

                sw.WriteLine($"{cliente.Nome};{cliente.CPF};{cliente.DataDeNascimento};{cliente.Endereco}");
                Console.WriteLine();
                Console.WriteLine("Cliente cadastrado com sucesso!\n");
                sw.Close();
            }
            Console.WriteLine("CPF já utilizado, cadastro cancelado.");
        }
        public List<Clientes> Listar()
        {
            CarregarClientesLista();

            return ListagemClientes;
        }
        #endregion

        #region Métodos Privados
        private Clientes LinhaTextoParaCliente(string linha)
        {
            var colunas = linha.Split(';');

            var clientes = new Clientes();
            clientes.Nome = colunas[0];
            clientes.CPF = colunas[1];
            clientes.DataDeNascimento = Convert.ToDateTime(colunas[2]);
            clientes.Endereco = colunas[3];

            return clientes;
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
            Clientes cliente = ListagemClientes.Find(x => x.CPF == cpf);

            if (cliente == null)
                return false;
            else
                return true;

        }
        #endregion
    }
}
