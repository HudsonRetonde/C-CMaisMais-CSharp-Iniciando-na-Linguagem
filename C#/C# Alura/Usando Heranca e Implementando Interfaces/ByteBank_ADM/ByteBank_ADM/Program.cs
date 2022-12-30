using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario pedro = new Funcionario("45698712166", 2000);
pedro.Nome = "Pedro Malazrtes";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Console.WriteLine();

Diretor roberta = new Diretor("98745622145", 5000);
roberta.Nome = "Roberta Souza";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

Console.WriteLine();

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine();
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
Console.WriteLine();
Console.WriteLine();

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine("O novo salário do Pedro é: " + pedro.Salario);
Console.WriteLine("O novo salário da Roberta é: " + roberta.Salario);