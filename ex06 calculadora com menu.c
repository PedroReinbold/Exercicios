/*Algoritmo que le dois valores e depois
      cria um menu de 4 opçoes:
      1-Somar, 2-Subtrair, 3-Dividir, 4-Multiplicar.*/


#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

void main(){

    setlocale(LC_ALL,"");
    int v1, v2, Escolha;
    bool a = true;

    printf("Digite dois valores para a calculadora: ");
    scanf("%d %d", &v1, &v2);
    printf("\nValores digitados: %d e %d.", v1, v2);

    while(a){
        printf("O que deseja fazer?\n1)Somar\n2)Subtrair\n3)Dividir\n4)Multiplicar\n\nEscolha: ");
        scanf("%d", &Escolha);

        switch(Escolha){
        case 1:
            a = false;
            printf("\nA soma entre %d e %d é = %d",v1, v2, v1 + v2);
            break;
        case 2:
            a = false;
            printf("\nA subtraçao entre %d e %d é = %d",v1, v2, v1 - v2);
            break;
        case 3:
            a = false;
            printf("\nA divisao entre %d e %d é = %d",v1, v2, v1 / v2);
            break;
        case 4:
            a = false;
            printf("\nA multiplicaçao entre %d e %d é = %d",v1, v2, v1 * v2);
            break;
        default:
            printf("\nInsira um valor válido.\n\n");
        }



    }







}
