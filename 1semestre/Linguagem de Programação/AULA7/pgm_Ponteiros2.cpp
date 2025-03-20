#include<stdio.h>
#include<stdlib.h>

void FuncaoExemplo(int *P) {
  *P = 1119;
}

int main() {
  int A = 183; // A é uma variável estática
 
  printf("Endereco de A = %d\n", &A);
  printf("Tamanho de A = %d bytes\n", sizeof(A));
  printf("Conteudo de A = %d\n\n", A);
   
  FuncaoExemplo(&A);
   
  printf("Endereco de A = %d\n", &A);
  printf("Tamanho de A = %d bytes\n", sizeof(A));
  printf("Conteudo de A = %d\n\n", A);

  printf("\n\nFim do Programa");
}
