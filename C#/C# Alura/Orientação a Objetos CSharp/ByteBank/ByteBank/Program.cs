using ByteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("O saldo da conta do André é " + contaDoAndre.saldo +" reais.");

contaDoAndre.Depositar(100);

Console.WriteLine("O saldo da conta do André pós-depósito é " + contaDoAndre.saldo + " reais.");

if (contaDoAndre.Sacar(50) == true)
{  
    Console.WriteLine("O saldo da conta do André pós-saque é " + contaDoAndre.saldo + " reais.");
} else {
        Console.WriteLine("O valor solicitado é maior que o saldo disponíel em conta. Operação invalidada...");
}

Console.WriteLine();


ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-y";
contaDaMaria.saldo = 350;

Console.WriteLine("O saldo da conta da Maria é " + contaDaMaria.saldo + " reais.");

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine();
Console.WriteLine("Saldo do André  é R$ " + contaDoAndre.saldo + " reais.");
Console.WriteLine("Saldo da Maria é R$ " + contaDaMaria.saldo + " reais.");

Console.WriteLine();

ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.titular = "Pedro Silva";
Console.WriteLine(contaDoPedro.titular);
Console.WriteLine(contaDoPedro.saldo);
Console.WriteLine(contaDoPedro.numero_agencia);
Console.WriteLine(contaDoPedro.conta);


