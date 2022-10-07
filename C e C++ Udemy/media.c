#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
    //Para usar acentos
    setlocale(LC_ALL, "");

    // crie algorítimos que leia duas notas e mostre a média entre elas.

    // definindo variáveis
    float nota1, nota2, resultado;

    //Lendo primeiro valor

    printf("A primeira nota é:");
    scanf("%f", &nota1);

    //Lendo o segundo valor

    printf("A segunda nota é:");
    scanf("%f", &nota2);

    //Calculando e mostrando o resultado final

    resultado = (nota1 + nota2) / 2;
    printf("A média das notas é %f",resultado);

}
