#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
    //Para usar acentos
    setlocale(LC_ALL, "");

    //Crie um algoritimo que leia 3 n�meros inteiros de uma s� vez e
    //coloque os resultados da multiplica��o entre os 3 em uma vari�vel pr�pria, depois exima essa vari�vel.

    int valor1, valor2, valor3, resultado;

    printf("Digite tr�s n�meros separados por espa�o\n");

    scanf("%d %d %d", &valor1, &valor2, &valor3);

    printf("\n");

    resultado = valor1 * valor2 * valor3;

    printf("O resultado da multiplica��o dos tr�s valores � %d", resultado);
}
