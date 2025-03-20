/* Exemplo de uso de struct */

#include<stdio.h>
#include<stdlib.h>

struct Estrutura {
  int A;
  int B;
  double X, Y, Z;
  char nome[50];
};

void ExibeEstrutura(Estrutura estrut) {
  printf("Conteudo da %s:\n", estrut.nome);
  printf("  A = %d\n", estrut.A);
  printf("  B = %d\n", estrut.B);
  printf("  X = %lf\n", estrut.X);
  printf("  Y = %lf\n", estrut.Y);
  printf("  Z = %lf\n\n", estrut.Z);
}

int main() {
  Estrutura Dados[100], aux; 
  int Tam, i;
  FILE *Arq;
  
  Tam = 0;
  Arq = fopen("dados.txt", "r");
  while ( fscanf(Arq, "%d;%d;%lf;%lf;%lf;%s", &aux.A, &aux.B, &aux.X, &aux.Y, &aux.Z, &aux.nome) != EOF ){
    Dados[Tam] = aux;
    Tam++;
  }
  fclose(Arq);

  for (i = 0; i < Tam; i++)
    ExibeEstrutura(Dados[i]);

  printf("\n\nFim do Programa");
}










