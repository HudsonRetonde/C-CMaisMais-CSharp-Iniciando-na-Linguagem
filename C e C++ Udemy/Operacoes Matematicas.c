#include <stdio.h>
#include <stdlib.h>

//Fun��o Principal do Programa
void main() {
  //Definindo Vari�veis

  int a =6, b = 3;

  //soma
  printf("\n A soma de %d mais %d eh = %d", a, b, a + b);

  //subtra��o
  printf("\n A subtra��o de %d mais %d eh = %d", a, b, a - b);

  //multiplica��o
  printf("\n A multiplica��o de %d mais %d eh = %d", a, b, a * b);

  //divis�o
  printf("\n A divis�o de %d mais %d eh = %d", a, b, a / b);

  //resto
  printf("\n O resto da divis�o entre %d mais %d eh = %d", a, b, a % b);

  //Valor Absoluto
  printf("\n O valor absoluto de -3 eh: %d", abs(-3));

  //pausa o programa ap�s executar

  system("pause");

}
