#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	int A, B, C, D, soma;
	double media;
	
	printf("Insira o valor da letra A: ");
	scanf("%d", &A);
	
	printf("Insira o valor da letra B: ");
	scanf("%d", &B);
	
	printf("Insira o valor da letra C: ");
	scanf("%d", &C);
	
	printf("Insira o valor da letra D: ");
	scanf("%d", &D);
	
	soma = A + B + C + D;
	media = soma / 4;
	
	printf("A soma dos números resultou em %d e sua média em %.2lf", soma, media);

	printf("\n\nFim do programa");
	return 0;
}
