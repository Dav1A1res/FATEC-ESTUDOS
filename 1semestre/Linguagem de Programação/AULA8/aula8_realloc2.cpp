#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(){
	setlocale(LC_ALL, "");
	
	int X, i;
	int tam;
	FILE *arq;
	int *V;
	
	arq = fopen("dados.txt", "r");
	V =  NULL;
	tam = 0;
	while (fscanf(arq, "%d", &X) != EOF ){
		tam++;
		V = (int *)realloc(V, sizeof(int) * tam);
		V[tam-1] = X;
		}
		fclose(arq);
		
		printf("\nVetor lido tem %d elementos\n", tam);
		for (i = 0; i < tam; i++){
			printf("%d, ", V[i]);
	}
	
	
	free(V);
	printf("\n\nFim do programa");
	return 0;
}
