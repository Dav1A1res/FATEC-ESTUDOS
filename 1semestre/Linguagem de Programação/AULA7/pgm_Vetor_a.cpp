/* Escreva um programa que leia 5 números inteiros e os coloque em um
   vetor. Exiba o vetor na tela. */
// Solução usando vetor estático
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
