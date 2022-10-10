#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
    //Para usar acentos
    setlocale(LC_ALL, "");

    //Crie um algoritimo que leia 3 números inteiros de uma só vez e
    //coloque os resultados da multiplicação entre os 3 em uma variável própria, depois exima essa variável.

    int valor1, valor2, valor3, resultado;

    printf("Digite três números separados por espaço\n");

    scanf("%d %d %d", &valor1, &valor2, &valor3);

    printf("\n");

    resultado = valor1 * valor2 * valor3;

    printf("O resultado da multiplicação dos três valores é %d", resultado);
}
