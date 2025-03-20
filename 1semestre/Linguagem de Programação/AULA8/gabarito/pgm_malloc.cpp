/* Escreva um programa que leia um número inteiro N, que será usado
   como tamanho de um vetor dinâmico. Preencha esse vetor (todas as
   posições) com inteiros aleatórios entre 1 e 1000 e mostre na tela.
   
   Esta solução demonstra o uso correto de malloc
   */

#include<stdio.h>
#include<stdlib.h>
#include<time.h>

int main() {
  int N, i;
  int *V;
  FILE *Arq;
  
  srand(time(NULL));
  printf("Digite o tamanho do vetor: ");
  scanf("%d", &N);
  V = (int *)malloc(sizeof(int) * N);

  for (i = 0; i < N; i++)
    V[i] = rand() % 1000 + 1;

  if (N < 1000) {
    printf("\nVetor Resultante\n");
    for (i = 0; i < N; i++) {
      printf("%d, ", V[i]);
    }
  }

  Arq = fopen("dados.txt", "w");
  for (i = 0; i < N; i++) {
    fprintf(Arq, "%d\n", V[i]);
  }
  fclose(Arq);


  free(V);
  printf("\n\nFim do Programa");
}
