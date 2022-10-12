#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){

    //Para usar acentos
    setlocale(LC_ALL, "");

    /*Crie um algoritmo que leia dois valores e depois crie um menu (Usando Switch Case)
    de 4 opções:1-Somar, 2-Subtrair,3-Dividir,4-Multiplicar.
    Depois que o usuário escolher uma opção, mostre o resultado da operação escolhida
    com os dois valores lidos.*/
    float valor1, valor2;
    int opcao;

    printf("Digite o primeiro valor:");
    scanf("%f", &valor1);
    printf("Digite o segundo valor:");
    scanf("%f", &valor2);

    printf("\nBoa tarde coleguinha, escolha uma opção:");
    printf("\n1-Somar");
    printf("\n2-Subtrair");
    printf("\n3-Dividir");
    printf("\n4-Multiplicar");
    scanf("%d", &opcao);
    switch(opcao){
        case 1:
            printf("Resultado da soma: %.2f", valor1 + valor2);
            break;
        case 2:
            printf("Resultado da subtração: %.2f", valor1 - valor2);
            break;
        case 3:
            printf("Resultado da divisão: %.2f", valor1 / valor2);
            break;
        case 4:
            printf("Resultado da multiplicação: %.2f", valor1 * valor2);
            break;
        default:
            printf("Opção inválida!");
            break;
    }

}

