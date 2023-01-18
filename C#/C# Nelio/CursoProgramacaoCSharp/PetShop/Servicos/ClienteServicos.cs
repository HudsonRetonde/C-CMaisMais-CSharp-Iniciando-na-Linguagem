using PetShop.Models;
using PetShop.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetShop.Servicos
{
    internal class ClienteServicos
    {
        private readonly Repositorios.ClienteRepositorio _repositorio;
        public ClienteServicos()
        {
            _repositorio = new Repositorios.ClienteRepositorio();
        }

        public void Perguntar()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("######################################################");
                Console.WriteLine("###################### PET SHOP ######################");
                Console.WriteLine("######################################################\n \n");
                Console.WriteLine("Escreva a opção desejeda e aperte 'Enter': \n");
                Console.WriteLine("1) Registrar clientes.\n" +
                                  "2) Mostrar clientes.\n" +
                                  "3) Encontrar um cliente por CPF.\n" +
                                  "4) Mostra na tela os aniversariantes do mês.\n");
                Console.WriteLine("5) Para sair.\n");

                char opcao = char.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case '1':
                        CadastrarCliente();
                        break;
                    case '2':
                        ListarClientes();
                        break;
                    case '3':
                        BuscarCliente();
                        break;
                    case '4':
                        BuscaAniversariantes();
                        break;
                }

                if (opcao == '5')
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
                if (ValidaUtil.ValidaNome(nome))
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
                if (ValidaUtil.ValidaCPF(cpf))
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
                if (ValidaUtil.ValidaNascimento(nascimento))
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
                if (ValidaUtil.ValidaEndereco(endereco))
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

            Clientes clientes = new Clientes(nome, cpf, dataNascimento, endereco);
            _repositorio.Inserir(clientes);
        }
        private void ListarClientes()
        {
            var clientes = _repositorio.Listar();
            if (clientes.Count == 0)
            {
                Console.WriteLine("Não há clientes cadastrados.");
                return;
            }
            foreach (Clientes cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.CPF);
                Console.WriteLine("Data de Nascimento: " + cliente.DataDeNascimento.ToString("dd/MM/yyyy"));
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
                if (ValidaUtil.ValidaCPF(cpf))
                    break;
                else
                    Console.WriteLine("Digite um CPF válido! Digite novamente.");
            }
            Clientes cliente = _repositorio.Listar().Find(c => c.CPF == cpf);
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
            }
            else
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.CPF);
                Console.WriteLine("Data de Nascimento: " + cliente.DataDeNascimento);
                Console.WriteLine("Endereco: " + cliente.Endereco);
            }
        }
        private void BuscaAniversariantes()
        {
            List<Clientes> aniversariantesMes = _repositorio.Listar().FindAll(c => c.DataDeNascimento.Month == DateTime.Now.Month);
            if (aniversariantesMes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente faz aniversário este mês! \n");
            }
            else
            {
                Console.WriteLine("Os cliente que fazem aniversário neste mês: ");
                foreach (Clientes obj in aniversariantesMes)
                {
                    Console.WriteLine($"{obj.Nome} data: {obj.DataDeNascimento.ToString("dd/MM")} \n");
                }
            }
        }

    }
}
