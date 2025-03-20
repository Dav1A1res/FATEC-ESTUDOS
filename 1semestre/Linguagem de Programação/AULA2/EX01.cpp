#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	double B, A, AREA;
	
	printf("Insira o valor da base do triângulo: ");
	scanf("%lf", &B);
	
	printf("Insira o valor da altura do triângulo: ");
	scanf("%lf", &A);
	
	AREA = (B * A) / 2;
	
	printf("A área do triângulo é de %.2lf", AREA);

	printf("\n\nFim do programa");
	return 0;
}
