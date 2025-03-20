/* Escreva um programa que leia 5 n�meros inteiros e os coloque em um
   vetor. Exiba o vetor na tela. */
// Solu��o usando vetor din�mico amplo
#include<stdio.h>
#include<stdlib.h>

int main() {
  int i, N;
  int *V; // Vetor din�mico amplo

  printf("Digite N: ");
  scanf("%d", &N);
  V = (int *)malloc(sizeof(int) * N);
       
  for (i = 0; i < N; i++) {
    //printf("Digite o elemento %d: ", i);
    //scanf("%d", &V[i]);
    V[i] = rand() % 100;
  }
   
  printf("\nResultado:\n");
  for (i = 0; i < N; i++) {
    printf("%d, ", V[i]);
  }

  free(V);
  printf("\n\nFim do Programa");
}





