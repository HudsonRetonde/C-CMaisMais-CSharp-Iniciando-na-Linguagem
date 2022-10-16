#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main(){
    setlocale(LC_ALL, "");

    int i = 0;

    for(i = 10; i >= 0; i--){
        printf("%d \n", i);
    }
}
