#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
    //Para usar acentos
    setlocale(LC_ALL, "");

    // crie algor�timos que leia duas notas e mostre a m�dia entre elas.

    // definindo vari�veis
    float nota1, nota2, resultado;

    //Lendo primeiro valor

    printf("A primeira nota �:");
    scanf("%f", &nota1);

    //Lendo o segundo valor

    printf("A segunda nota �:");
    scanf("%f", &nota2);

    //Calculando e mostrando o resultado final

    resultado = (nota1 + nota2) / 2;
    printf("A m�dia das notas � %f",resultado);

}
