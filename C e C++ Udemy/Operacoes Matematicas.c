#include <stdio.h>
#include <stdlib.h>

//Função Principal do Programa
void main() {
  //Definindo Variáveis

  int a =6, b = 3;

  //soma
  printf("\n A soma de %d mais %d eh = %d", a, b, a + b);

  //subtração
  printf("\n A subtração de %d mais %d eh = %d", a, b, a - b);

  //multiplicação
  printf("\n A multiplicação de %d mais %d eh = %d", a, b, a * b);

  //divisão
  printf("\n A divisão de %d mais %d eh = %d", a, b, a / b);

  //resto
  printf("\n O resto da divisão entre %d mais %d eh = %d", a, b, a % b);

  //Valor Absoluto
  printf("\n O valor absoluto de -3 eh: %d", abs(-3));

  //pausa o programa após executar

  system("pause");

}
