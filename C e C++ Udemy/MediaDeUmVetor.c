#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main() {

    //Para usar acentos
    setlocale(LC_ALL,"");

    //Criando um algoritimo que leia 3 valores para um vetor de 3 posições e depois calcule a média dos valores acessando o vetor

    int tamanho;
    printf("Qual será o tamanho do seu vetor?");
    scanf("%d", &tamanho);

    float vetor[tamanho], soma;
    int i;
    for(i = 0; i < tamanho; i++){
        printf("Digite um valor: ");
        scanf("%f", &vetor[i]);
        soma = soma + vetor[i];
    }
    for(i = 0; i < tamanho; i++) {
        printf("\nvetor[%d] = %.2f", i, vetor[i]);
    }

    printf("\nA média dos vetores é: %.2f", soma / tamanho);
}
