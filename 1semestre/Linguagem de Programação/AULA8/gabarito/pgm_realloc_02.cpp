/* Escreva um programa que leia inteiros positivos de um arquivo em
   disco, com um valor gravado em cada linha.
   Cada valor deve ser inserido no final de um vetor dinâmico.
   Mostrar o vetor na tela.
   
   Esta solução demonstra o uso correto de realloc
   */

#include<stdio.h>
#include<stdlib.h>

int main() {
  int X, i;
  int *V;
  int Tam;
  FILE *Arq;

  Arq = fopen("dados.txt", "r");
  V = NULL;
  Tam = 0; 
  while ( fscanf(Arq, "%d", &X) != EOF ) {
    Tam++;
    V = (int *)realloc(V, sizeof(int) * Tam);
    V[Tam-1] = X;
  }
  fclose(Arq);

  printf("\nO Vetor lido tem %d elementos\n", Tam);
  for (i = 0; i < Tam; i++) {
    printf("%d, ", V[i]);
  }

  free(V);
  printf("\n\nFim do Programa");
}
