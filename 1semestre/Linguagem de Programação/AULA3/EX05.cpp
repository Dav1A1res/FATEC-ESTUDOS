#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");

	double A, B, C;
	
	printf("Insira o valor do lado A: ");
	scanf("%lf", &A);
	printf("Insira o valor do lado B: ");
	scanf("%lf", &B);
	printf("Insira o valor do lado C: ");
	scanf("%lf", &C);

	if (A + B > C && B + C > A && A + C > B){
		if (A == B && B == C){
			printf("� um tri�ngulo equil�tero!");
		} 
		else if(A == B || B == C || C == A){
			printf("� um tri�ngulo is�sceles!");
		}
		else{
			printf("� um tri�ngulo escaleno!");
		}
	}
	else{
		printf("N�o � um tri�ngulo!");
	}

	printf("\n\nFim do programa");
	return 0;
}
