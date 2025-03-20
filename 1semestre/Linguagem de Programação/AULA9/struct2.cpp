#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

struct Estrutura {
	int A;
	int B;
	char nome[50];
	double x,y,z;
};

void ExibeEstrutura(Estrutura estrut){
	printf("Conteúdo da estrutura: \n");
	printf("A = %d\n", estrut.A);
	printf("B = %d\n", estrut.B);
	printf("X = %lf\n", estrut.x);
	printf("Y = %lf\n", estrut.y);
	printf("Z = %lf\n", estrut.z);
	printf("Nome = %s\n\n", estrut.nome);
}

int main(){
	setlocale(LC_ALL, "");
	
	Estrutura Dados[100], aux;
	int tam, i;
	FILE *Arq;
	
	tam = 0;
	Arq = fopen("dados.txt", "r");
	while( fscanf(Arq, "%d;%d;%lf;%lf.1;%lf;%s",aux.A, aux.B, aux.x, aux.y, aux.z, aux.nome ) != EOF) {
		Dados[tam] = aux;
		tam++;
	}
	fclose(Arq);
	
	for(i = 0; i < tam; i++)
		ExibeEstrutura(Dados[i]);
		
	printf("\n\nFim do programa");
	return 0;
}
