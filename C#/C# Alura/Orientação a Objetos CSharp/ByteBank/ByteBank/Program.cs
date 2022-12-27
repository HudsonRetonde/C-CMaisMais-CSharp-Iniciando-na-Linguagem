using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;
//Console.WriteLine("O saldo da conta do André é " + contaDoAndre.saldo + " reais.");

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-x";
//contaDoAndre2.saldo = 100;
//Console.WriteLine("O saldo da segunda conta do André é " + contaDoAndre2.saldo + " reais.");

//contaDoAndre = contaDoAndre2;

//Console.WriteLine(contaDoAndre == contaDoAndre2);

//Console.WriteLine("O saldo da conta do André é " + contaDoAndre.saldo +" reais.");

//contaDoAndre.Depositar(100);

//Console.WriteLine("O saldo da conta do André pós-depósito é " + contaDoAndre.saldo + " reais.");

//if (contaDoAndre.Sacar(50) == true)
//{  
//    Console.WriteLine("O saldo da conta do André pós-saque é " + contaDoAndre.saldo + " reais.");
//} else {
//        Console.WriteLine("O valor solicitado é maior que o saldo disponíel em conta. Operação invalidada...");
//}

//Console.WriteLine();


//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-y";
//contaDaMaria.saldo = 350;

//Console.WriteLine("O saldo da conta da Maria é " + contaDaMaria.saldo + " reais.");

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine();
//Console.WriteLine("Saldo do André  é R$ " + contaDoAndre.saldo + " reais.");
//Console.WriteLine("Saldo da Maria é R$ " + contaDaMaria.saldo + " reais.");

//Console.WriteLine();

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "12345678945";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome + ".");
//Console.WriteLine("CPF = " + conta.titular.cpf + ".");
//Console.WriteLine("Profissão = " + conta.titular.profissao + ".");
//Console.WriteLine("Conta-corrente = " + conta.conta + ".");
//Console.WriteLine("Saldo = " + conta.saldo + ".");
//Console.WriteLine("Agência = " + conta.numero_agencia + ".");
//Console.WriteLine();

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.cpf = "98765432102";
//conta2.titular.profissao = "Tester";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

ContaCorrente conta3 = new ContaCorrente();
conta3.DefinirSaldo(1000);
Console.WriteLine(conta3.ObterSaldo());

