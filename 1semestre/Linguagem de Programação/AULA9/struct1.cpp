#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

struct Estrutura {
	int A;
	int B;
	char nome[50];
	double x;
	double y;
	double z;
};

void ExibeEstrutura(Estrutura estrut){
	printf("Conteúdo da estrutura: \n");
	printf("A = %d\n", estrut.A);
	printf("B = %d\n", estrut.B);
	printf("X = %lf\n", estrut.x);
	printf("Y = %lf\n", estrut.y);
	printf("Z = %lf\n", estrut.z);
	printf("Nome = %s\n", estrut.nome);
}

int main(){
	setlocale(LC_ALL, "");
	
	Estrutura D, E;
	
	D.A = 20;
	
	printf("Digite um valor para B: ");
	scanf("%d", &D.B);
	
	printf("Digite um valor para X: ");
	scanf("%lf", &D.x);
	
	if (D.B > 20)
		D.y = D.x / D.A;
	else
		D.y = D.x / D.B;
		D.z = D.x / D.y;
	printf("Digite o nome: ");
	scanf("%s", &D.nome);
	
	
	E = D;
	Estrutura(E);
	
	ExibeEstrutura(D);
		
	printf("\n\nFim do programa");
	return 0;
}
