#include <stdio.h>
#include <stdlib.h>

void main(){

    int cont, contM;

    for(cont = 1; cont <= 10; cont++){
        printf("\n%d", cont);
    }

    printf("\n");

    for(contM = 10; contM >= 1; contM--){
        printf("\n%d", contM);
    }

    printf("\n");

    //Tabuada do 5
    for(cont = 1; cont <= 10; cont++){
        printf("\n 5 X %d = %d",cont, 5 * cont);
    }

    printf("\n");

    //Contando de 2 em 2
    for(cont = 0; cont <= 10; cont = cont + 2){
        printf("\n%d",cont);
    }

    system("pause");
}
