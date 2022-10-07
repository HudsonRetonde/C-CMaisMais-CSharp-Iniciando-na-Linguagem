#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
    //Permite usar acentos
    setlocale(LC_ALL,"");
    printf("Olá /n");

    int a = 50;
    int b = 28;
    printf("%d", a - b);

}
