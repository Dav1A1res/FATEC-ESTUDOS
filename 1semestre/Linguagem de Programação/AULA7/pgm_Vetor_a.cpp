/* Escreva um programa que leia 5 n�meros inteiros e os coloque em um
   vetor. Exiba o vetor na tela. */
// Solu��o usando vetor est�tico
#include<stdio.h>
#include<stdlib.h>

int main() {
  int V[5];
  int i;
  
  for (i = 0; i < 5; i++) {
    printf("Digite o elemento %d: ", i);
    scanf("%d", &V[i]);
  }
   
  printf("\nResultado:");
  for (i = 0; i < 5; i++) {
    printf(" %d, ", V[i]);
  }

  printf("\n\nFim do Programa");
}
