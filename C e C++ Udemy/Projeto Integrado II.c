#include <stdio.h>
#include <stdlib.h>
#include<locale.h>

void main(){

    //Para usar acentos
    setlocale(LC_ALL, "");

    //Fa�a um programa na linguagem C, utilizando qualquer compilador, em que pe�a como entrada,
    //seu nome, endere�o e telefone, por fim, exiba esses dados na tela


    char nome[30], endereco[100];
    int telefone;
    printf("Escreva os eu nome: ");
    scanf("%s", nome);

    printf("Qual o seu endere�o? ");
    scanf("%s", endereco);

    printf("Por gentileza, informe o n�mero do seu telefone: ");
    scanf("%d", telefonex);


}
