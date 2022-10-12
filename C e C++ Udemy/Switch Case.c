#include <stdio.h>
#include <stdlib.h>

void main(){

int a = 5;
char b = 'X';

    switch(a){
        case 1:
            printf("\n opção escolhida eh igual a 1.");
            break;

        case 2:
            printf("\n opção escolhida eh igual a 2.");
            break;

        case 3:
            printf("\n opção escolhida eh igual a 3:.");
            break;

        default:
            printf("Não eh 1, 2 ou 3.");
    }

    switch(b) {
        case 'X':
            printf("\n opção escolhida eh igual a X.");
            break;
        default:
            printf("Opção inválida.");

    }
}
