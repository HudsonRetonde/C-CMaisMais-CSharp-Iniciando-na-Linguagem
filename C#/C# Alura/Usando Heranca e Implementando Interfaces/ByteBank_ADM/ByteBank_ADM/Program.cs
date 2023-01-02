using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("45698712166", 2000);
//pedro.Nome = "Pedro Malazrtes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Console.WriteLine();

//Diretor roberta = new Diretor("98745622145");
//roberta.Nome = "Roberta Souza";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//Console.WriteLine();

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine();
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
//Console.WriteLine();
//Console.WriteLine();

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("O novo salário do Pedro é: " + pedro.Salario);
//Console.WriteLine("O novo salário da Roberta é: " + roberta.Salario);
# endregion
CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("15987456321");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("45698748596");
    paula.Nome = "Paula Fernandes";

    Auxiliar igor = new Auxiliar("98745898785");
    igor.Nome = "Igor Dão";

    GerenteDeContas fatima = new GerenteDeContas("36985478963");
    fatima.Nome = "Fatima Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(fatima);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}