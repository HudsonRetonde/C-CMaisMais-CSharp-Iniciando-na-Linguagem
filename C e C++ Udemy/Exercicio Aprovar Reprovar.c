#include <stdio.h>
#include <stdlib.h>
#include<locale.h>

void main(){

    //Para usar acentos
    setlocale(LC_ALL, "");

    //Crie um algoritimo que leia 3 notas e calcule a média entre elas;
    //Se o valor for maior que 7 informe aprovado, senão, reprovado.

    float nota1, nota2, nota3, media;

    printf("digite a primeira nota: ");
    scanf("%f", &nota1);

    printf("digite a segunda nota: ");
    scanf("%f", &nota2);

    printf("digite a terceira nota: ");
    scanf("%f", &nota3);

    media = (nota1 + nota2 + nota3) / 3;

    printf("\dA media final eh: %f",  media);

    if(media < 7) {
        printf("Reprovado!");
    }else{
        printf("Aprovado");
    }
}
