using ByteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("O saldo da conta do André é " + contaDoAndre.saldo +" reais.");

contaDoAndre.Depositar(100);

Console.WriteLine("O saldo da conta do André pós-depósito é " + contaDoAndre.saldo + " reais.");