#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
    //Para usar acentos
    setlocale(LC_ALL, "");

    int a = 4;

    if(a == 5) {
        printf("A variavel a � igual a 5");
    }

    if(a % 2 == 1) {
        printf("\n A vari�vel � �mpar...");
    } else {
        printf("\n A vari�vel � par...");
    }
}
