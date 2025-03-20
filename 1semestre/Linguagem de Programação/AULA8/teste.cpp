#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(){
	setlocale(LC_ALL, "");
	
	int N, i;
	int *V;
	
	printf("Digite o tamanho do vetor: ");
	scanf("%d", &N);
	
	V = (int *)malloc(sizeof(int) * N);
	
	for (i = 0; i < N; i++)
		V[i] = rand() % 1000 + 1;
		
				/* número entre 0 e 999 = rand % 1000
				   número entre 1 e 1000 = rand % 1000 + 1
				   número entre 6 e 12 = rand % 7 + 6
				   número com limites randomicos = rand % (fim - i * i + 1) + i * i
				 */
	
	printf("\nVetor resultante: ");
	for (i = 0; i < N; i++){
		printf("%d, ", V[i]);
	}
	
	
	free(V);
	printf("\n\nFim do programa");
	return 0;
}
