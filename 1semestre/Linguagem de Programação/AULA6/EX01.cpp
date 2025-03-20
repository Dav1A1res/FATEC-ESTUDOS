#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	int A[5] = {19, 23, 29, 31, 37};

	printf("Exibição dos vetores em ordem normal: %d, %d, %d, %d, %d ", A[0], A[1], A[2], A[3], A[4]);
	printf("\nExibição dos vetores em ordem invertida: %d, %d, %d, %d, %d ", A[4], A[3], A[2], A[1], A[0]);

	printf("\n\nFim do programa");
	return 0;
}
