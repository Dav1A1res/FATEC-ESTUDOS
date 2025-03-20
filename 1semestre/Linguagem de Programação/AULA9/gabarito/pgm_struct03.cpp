/* Exemplo de uso de struct */

#include<stdio.h>
#include<stdlib.h>

struct Estrutura {
  int A;
  int B;
  double X, Y, Z;
  char nome[50];
};

void ExibeDados(Estrutura *pV, int pTam) {
  for (int i = 0; i < pTam; i++) {
    printf("%10s", pV[i].nome);
    printf("%5d", pV[i].A);
    printf("%25d", pV[i].B);
    printf("%7.2lf", pV[i].X);
    printf("%7.1lf", pV[i].Y);
    printf("%7.3lf\n", pV[i].Z);
  }

}

int main() {
  Estrutura *Dados, aux; 
  int Tam, i;
  FILE *Arq;
  
  Dados = NULL;
  Tam = 0;
  Arq = fopen("dados.txt", "r");
  while ( fscanf(Arq, "%d;%d;%lf;%lf;%lf;%s", &aux.A, &aux.B, &aux.X, &aux.Y, &aux.Z, &aux.nome) != EOF ){
    Tam++;
    Dados = (Estrutura *)realloc(Dados, sizeof(Estrutura) * Tam);
    Dados[Tam-1] = aux;
  }
  fclose(Arq);

  ExibeDados(Dados, Tam);

  printf("\n\nFim do Programa");
}










