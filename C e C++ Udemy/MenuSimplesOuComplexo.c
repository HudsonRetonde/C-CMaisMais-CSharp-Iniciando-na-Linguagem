#include <stdio.h>
#include <stdlib.h>

void main(){
    int opcao;

    while(opcao <1 || opcao >3) {

        printf("Escolha uma opcao:");
        printf("\nOpcao 1: ");
        printf("\nOpcao 2: ");
        printf("\nOpcao 3:\n ");

        scanf("%d", &opcao);

        switch(opcao){
            case 1:
                printf("Voce escolheu a opcao 1");
                break;
            case 2:
                printf("Voce escolheu a opcao 2");
                break;
            case 3:
                printf("Voce escolheu a opcao 3");
                break;
            default:
                printf("Voce escolheu ama opcao invalida");
                break;

        }


    }

}
