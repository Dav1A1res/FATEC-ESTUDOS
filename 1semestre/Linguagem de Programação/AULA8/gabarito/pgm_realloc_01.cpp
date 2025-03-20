/* Escreva um programa que permaneça em laço lendo inteiros positivos.
   Cada valor deve ser inserido no final de um vetor dinâmico.
   O laço termina quando for digitado o valor zero ou negativo.
   Mostrar o vetor na tela.
   
   Esta solução demonstra o uso correto de realloc
   */

#include<stdio.h>
#include<stdlib.h>

int main() {
  int X, i;
  int *V;
  int Tam;

  V = NULL;
  Tam = 0; 
  printf("Digite um elemento para o vetor: ");
  scanf("%d", &X);
  while (X > 0) {
    Tam++;
    V = (int *)realloc(V, sizeof(int) * Tam);
    V[Tam-1] = X;
       
    printf("Digite um elemento para o vetor: ");
    scanf("%d", &X);
  }

  printf("\nO Vetor Resultante tem %d elementos\n", Tam);
  for (i = 0; i < Tam; i++) {
    printf("%d, ", V[i]);
  }

  free(V);
  printf("\n\nFim do Programa");
}
