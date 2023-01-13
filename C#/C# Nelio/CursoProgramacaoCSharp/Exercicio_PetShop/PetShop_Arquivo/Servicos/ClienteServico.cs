using PetShop_Arquivo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Utilitarios;

namespace PetShop_Arquivo.Servicos
{
    internal class ClienteServico
    {
        private readonly Repositorios.ClienteRepositorio _repositorio;
        public ClienteServico() 
        {
            _repositorio = new Repositorios.ClienteRepositorio();
        }

        public void Perguntar()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("*----------------- Sistema Pet Shop -----------------*\n \n");
                Console.WriteLine("Digite a opção desejeda e aperte 'Enter': \n");
                Console.WriteLine("a) Cadastrar clientes.\n" +
                                  "b) Listar clientes.\n" +
                                  "c) Buscar um cliente por CPF.\n" +
                                  "d) Listar os aniversariantes do mês.\n");
                Console.WriteLine("q) Para sair.\n");

                char opcao = char.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 'a':
                        CadastrarCliente();
                        break;
                    case 'b':
                        ListarClientes();
                        break;
                    case 'c':
                        BuscarCliente();
                        break;
                    case 'd':
                        BuscaAniversariantes();
                        break;
                }

                if (opcao == 'q')
                {
                    break;
                }
            }
        }
        private void CadastrarCliente()
        {
            Console.WriteLine("Informe os dados do cliente:\n");
            Console.Write("Primeiro nome (Em maiúsculo): ");
            string nome = "";
            while (true)
            {
                nome = Console.ReadLine();
                if (Uteis.ValidaNome(nome))
                {
                    Console.WriteLine("Nome válido\n");
                    break;

                }
                else
                {
                    Console.WriteLine("Nome inválido, digite novamente: \n");

                }
            }
            Console.Write("CPF: ");
            string cpf = "";
            while (true)
            {
                cpf = Console.ReadLine();
                cpf = Regex.Replace(cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})",
                                    "$1.$2.$3-$4");
                if (Uteis.ValidaCPF(cpf))
                {
                    Console.WriteLine("CPF válido!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("CPF inválido, digite novamente: \n");
                    continue;
                }
            }
            Console.Write("Insira a data de nascimente (dd/mm/yyyy): ");
            string nascimento;
            DateTime dataNascimento;
            while (true)
            {
                nascimento = (Console.ReadLine());
                if (Uteis.ValidaNascimento(nascimento))
                {
                    Console.WriteLine("Data de nascimento válida!\n");
                    dataNascimento = Convert.ToDateTime(nascimento);
                    break;
                }
            }
            Console.Write("Endereço: ");
            string endereco = "";
            while (true)
            {
                endereco = Console.ReadLine();
                if (Uteis.ValidaEndereco(endereco))
                {
                    Console.WriteLine("Endereço válido\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Endereço inválido, digite novamente: \n");
                    continue;
                }
            }

            Cliente cliente = new Cliente(nome, cpf, dataNascimento, endereco);       
            _repositorio.Inserir(cliente);
        }
        private void ListarClientes()
        {
            var clientes = _repositorio.Listar();
            if (clientes.Count == 0)
            {
                Console.WriteLine("Não há clientes cadastrados.");
                return;
            }
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.CPF);
                Console.WriteLine("Data de Nascimento: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
                Console.WriteLine("Endereço: " + cliente.Endereco);
                Console.WriteLine();
            }
        }
        private void BuscarCliente()
        {
            Console.Write("Digite o CPF do cliente: ");
            string cpf = "";
            while (true)
            {
                cpf = Console.ReadLine();
                cpf = Regex.Replace(cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})",
                                         "$1.$2.$3-$4");
                if (Uteis.ValidaCPFBusca(cpf))
                    break;
                else
                    Console.WriteLine("Digite um CPF válido! Digite novamente.");
            }
            Cliente cliente = _repositorio.Listar().Find(c => c.CPF == cpf);
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
            }
            else
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.CPF);
                Console.WriteLine("Data de Nascimento: " + cliente.DataNascimento);
                Console.WriteLine("Endereco: " + cliente.Endereco);
            }
        }
        private void BuscaAniversariantes()
        {
            List<Cliente> aniversariantesMes = _repositorio.Listar().FindAll(c => c.DataNascimento.Month == DateTime.Now.Month);
            if (aniversariantesMes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente faz aniversário este mês! \n");
            }
            else
            {
                Console.WriteLine("Os cliente que fazem aniversário neste mês: ");
                foreach (Cliente obj in aniversariantesMes)
                {
                    Console.WriteLine($"{obj.Nome} data: {obj.DataNascimento.ToString("dd/MM")} \n");
                }
            }
        }
    }
}
