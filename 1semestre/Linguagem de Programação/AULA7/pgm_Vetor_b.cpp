/* Escreva um programa que leia 5 números inteiros e os coloque em um
   vetor. Exiba o vetor na tela. */
// Solução usando vetor dinâmico restrito
#include<stdio.h>
#include<stdlib.h>

int main() {
  int i, N;

  printf("Digite N: ");
  scanf("%d", &N);

  int V[N]; // Vetor dinâmico restrito

  for (i = 0; i < N; i++) {
    //printf("Digite o elemento %d: ", i);
    //scanf("%d", &V[i]);
    V[i] = rand() % 100;
  }
   
  printf("\nResultado:\n");
  for (i = 0; i < N; i++) {
    printf("%d, ", V[i]);
  }

  printf("\n\nFim do Programa");
}





