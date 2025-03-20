#include<stdio.h>
#include<stdlib.h>

int main() {
  int A = 183; // A é uma variável estática
  int *P;      // P é um ponteiro
  
  printf("Endereco de A = %d\n", &A);
  printf("Tamanho de A = %d bytes\n", sizeof(A));
  printf("Conteudo de A = %d\n\n", A);
   
  P = &A;
  printf("Endereco de P = %d\n", &P);
  printf("Conteudo de P = %d\n\n", P);
  
  *P = 100; // Alteração do conteúdo de A de forma indireta, usando o ponteiro P
  printf("Conteudo de A = %d\n\n", A);
  
  P[0] = 216; // Alteração do conteúdo de A de forma indireta, usando o ponteiro P na forma indexada
  printf("Conteudo de A = %d\n\n", A);

  printf("\n\nFim do Programa");
}
