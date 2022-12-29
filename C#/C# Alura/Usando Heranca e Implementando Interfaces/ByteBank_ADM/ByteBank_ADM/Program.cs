using ByteBank_ADM.Funcionarios;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazrtes";
pedro.Cpf = "45698712166";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());