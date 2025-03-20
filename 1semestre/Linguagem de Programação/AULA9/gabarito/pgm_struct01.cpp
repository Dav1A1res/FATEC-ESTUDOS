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
  printf("Conteudo da estrutura:\n");
  printf("  A = %d\n", estrut.A);
  printf("  B = %d\n", estrut.B);
  printf("  X = %lf\n", estrut.X);
  printf("  Y = %lf\n", estrut.Y);
  printf("  Z = %lf\n", estrut.Z);
  printf("  nome = %s\n\n", estrut.nome);
}

int main() {
  Estrutura D, E;  
  
  // Exemplo de carregamento de dados em uma estrutura
  D.A = 28;
  printf("Digite um valor para B: ");
  scanf("%d", &D.B);
  printf("Digite um valor para X: ");
  scanf("%lf", &D.X);
  if (D.B > 20) 
    D.Y = D.X / D.A;
  else
    D.Y = D.X / D.B;
  D.Z = D.X + D.Y;
  printf("Digite o nome: ");
  scanf("%s", &D.nome);
  ExibeEstrutura(D);

  E = D;
  ExibeEstrutura(E);


  printf("\n\nFim do Programa");
}










