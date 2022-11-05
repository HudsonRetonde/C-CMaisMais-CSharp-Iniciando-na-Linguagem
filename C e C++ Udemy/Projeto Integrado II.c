#include <stdio.h>
#include <stdlib.h>
#include<locale.h>

void main(){

    //Para usar acentos
    setlocale(LC_ALL, "");

    //Faça um programa na linguagem C, utilizando qualquer compilador, em que peça como entrada,
    //seu nome, endereço e telefone, por fim, exiba esses dados na tela


    char nome[30], endereco[100];
    int telefone;
    printf("Escreva os eu nome: ");
    scanf("%s", nome);

    printf("Qual o seu endereço? ");
    scanf("%s", endereco);

    printf("Por gentileza, informe o número do seu telefone: ");
    scanf("%d", telefonex);


}
