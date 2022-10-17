#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){

    setlocale(LC_ALL,"");

    int valor1, i;

    for(i = 10; i<= 20; i++){
        if(i % 2 ==0){
            printf("%d é par \n", i);
        } else {
            printf("%d é ímpar \n", i);
        }
    };
}
