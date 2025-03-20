#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(){
	setlocale(LC_ALL, "");
	
	int X, i;
	int tam;
	int *V;
	
	V =  NULL;
	tam = 0;
	
	printf("Digite um elemento para o vetor: ");
	scanf("%d", &X);
	
	while (X > 0){
		tam++;
		V = (int *)realloc(V, sizeof(int) * tam);
		V[tam-1] = X;
	
		printf("Digite um elemento para o vetor: ");
		scanf("%d", &X);
		}
		
		printf("\nVetor resultante: ");
		for (i = 0; i < tam; i++){
			printf("%d, ", V[i]);
	}
	
	
	free(V);
	printf("\n\nFim do programa");
	return 0;
}
