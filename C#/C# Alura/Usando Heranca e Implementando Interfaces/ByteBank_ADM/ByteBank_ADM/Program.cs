﻿using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario pedro = new Funcionario("45698712166");
pedro.Nome = "Pedro Malazrtes";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Console.WriteLine();

Diretor roberta = new Diretor("98745622145");
roberta.Nome = "Roberta Souza";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

Console.WriteLine();

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine();
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);