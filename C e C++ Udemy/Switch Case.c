#include <stdio.h>
#include <stdlib.h>

void main(){

int a = 5;
char b = 'X';

    switch(a){
        case 1:
            printf("\n op��o escolhida eh igual a 1.");
            break;

        case 2:
            printf("\n op��o escolhida eh igual a 2.");
            break;

        case 3:
            printf("\n op��o escolhida eh igual a 3:.");
            break;

        default:
            printf("N�o eh 1, 2 ou 3.");
    }

    switch(b) {
        case 'X':
            printf("\n op��o escolhida eh igual a X.");
            break;
        default:
            printf("Op��o inv�lida.");

    }
}
