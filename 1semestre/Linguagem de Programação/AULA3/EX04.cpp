#include <stdio.h>
#include <locale.h>
#include <math.h>

int main(){
	setlocale(LC_ALL, "");
	
	double A, B, C, delta;
	
	printf("Insira o valor de A: ");
	scanf("%lf", &A);
	printf("Insira o valor de B: ");
	scanf("%lf", &B);
	printf("Insira o valor de C: ");
	scanf("%lf", &C);

	delta = B * B - 4 * A * C;
		
	printf("DELTA = %.0lf", delta);
	
	if (delta < 0) {
		printf("\nNão há raízes reais!");
	}
	else if (delta == 0){
		double raiz1 = -B / (2 * A);
		printf("\nHá uma raíz real: %.0lf", raiz1);
	}
	else {
		double raiz2 = (-B + sqrt(delta)) / (2 * A);
		double raiz3 = (-B - sqrt(delta)) / (2 * A);
		printf("\nHá duas raízes reais: %.0lf e %.0lf", raiz2, raiz3);
	}

	printf("\n\nFim do programa");
	return 0;
}
