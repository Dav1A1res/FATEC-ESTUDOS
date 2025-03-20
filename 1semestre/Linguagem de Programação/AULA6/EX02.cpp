#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	double V[10];
	int i =  0, c = 0;
	
	printf("Insira um total de 10 números para serem exibidos. Digite 0 para parar o programa antes se desejar.\n\n");
	
	do {
		printf("\nDigite um número: ");
		scanf("%lf", &V[i]);
		i++;
	} while (V[i - 1] != 0 && i < 10);

	printf("\nExibição dos valores:\n\n");
	for (c; c < i; c++) {
	    printf("%.2lf\n", V[c]);
	}

	printf("\n\nFim do programa");
	return 0;
}
